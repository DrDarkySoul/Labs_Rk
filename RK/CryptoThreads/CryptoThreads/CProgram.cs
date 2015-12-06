using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace CryptoThreads
{
    class CProgram
    {
        static String pathInput = "";
        static String filter = "*.*";
        static String name = "";

        static byte[] IV;
        static byte[] Key;

        static Thread writeline;

        static FileSystemEventArgs _event;

        static long count = 0;

        static void Main(string[] args)
        {
            FileSystemWatcher _watcher = new FileSystemWatcher(pathInput, filter);
            try
            {
                _watcher.EnableRaisingEvents = true;
                _watcher.Created += new FileSystemEventHandler(LogFileSystemChanges);
                _watcher.Changed += new FileSystemEventHandler(LogFileSystemChanges);
            }
            finally
            {
                _watcher.EnableRaisingEvents = true;
            }
            Console.Read();
        }

        static void LogFileSystemChanges(object sender, FileSystemEventArgs e)
        {
            _event = e;
            name = e.Name;
            writeline = new Thread(() => ConsoleWriteLine(_event));
            writeline.IsBackground = true;
            writeline.Start();
            MemoryStream mainStream = EncryptFile(e.FullPath);
            Thread.Sleep(500);
            Client(mainStream);
            mainStream.Dispose();
        }

        static void ConsoleWriteLine(FileSystemEventArgs e)
        {
            if (e.ChangeType == System.IO.WatcherChangeTypes.Changed)
            {
                Console.WriteLine(" File: {0}  {1} \n", e.FullPath, e.ChangeType);
            }
            else
            {
                Console.WriteLine(" New file created: {0}\n", e.FullPath);
            } 
        }

        public static MemoryStream EncryptFile(string inputFile)
        {
            try
            {
                using (RijndaelManaged aes = new RijndaelManaged())
                {
                    aes.GenerateKey();
                    Key = aes.Key;
                    aes.GenerateIV();
                    IV = aes.IV;
                    count = 0;
                    using (MemoryStream cryptoStream = new MemoryStream())
                    {
                        using (ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV))
                        {
                            using (CryptoStream cs = new CryptoStream(cryptoStream, encryptor, CryptoStreamMode.Write))
                            {
                                using (FileStream fsIn = new FileStream(inputFile, FileMode.Open))
                                {
                                    int data;
                                    while ((data = fsIn.ReadByte()) != -1)
                                    {
                                        cs.WriteByte((byte)data);
                                    }
                                }
                            }
                        }
                        byte[] exp = cryptoStream.ToArray();
                        count = exp.Length;
                        return cryptoStream;
                    }
                    }
                }         
            catch (Exception ex)
            {
                Console.WriteLine(ex);  // failed to encrypt file
                return null;
            }
        }

        static void Client( MemoryStream _byte)
        {
            try
            {
                SendMessageFromSocket(11000, _byte);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static void SendMessageFromSocket(int port, MemoryStream _byte)
        {
            // Буфер для входящих данных
            byte[] bytes = new byte[1024];

            // Соединяемся с удаленным устройством

            // Устанавливаем удаленную точку для сокета
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);

            Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            // Соединяем сокет с удаленной точкой
            sender.Connect(ipEndPoint);

            Console.WriteLine("Сокет соединяется с {0} \n", sender.RemoteEndPoint.ToString());
            byte[] msg = IV;

            // Отправляем данные через сокет
            int bytesSent = sender.Send(msg);

            // Получаем ответ от сервера
            int bytesRec = sender.Receive(bytes);
            Console.WriteLine("\nОтвет от сервера: {0}\n", Encoding.UTF8.GetString(bytes, 0, bytesRec));

            msg = Key;

            bytesSent = sender.Send(msg);

            // Получаем ответ от сервера
            bytesRec = sender.Receive(bytes);
            Console.WriteLine("\nОтвет от сервера: {0}\n", Encoding.UTF8.GetString(bytes, 0, bytesRec));

            msg = BitConverter.GetBytes(count);
            bytesSent = sender.Send(msg);

            // Получаем ответ от сервера
            bytesRec = sender.Receive(bytes);
            Console.WriteLine("\nОтвет от сервера: {0}\n", Encoding.UTF8.GetString(bytes, 0, bytesRec));

            msg = Encoding.UTF8.GetBytes(name);
            bytesSent = sender.Send(msg);

            // Получаем ответ от сервера
            bytesRec = sender.Receive(bytes);
            Console.WriteLine("\nОтвет от сервера: {0}\n", Encoding.UTF8.GetString(bytes, 0, bytesRec));

            //Отправляем поток
            msg = _byte.ToArray();
            bytesSent = sender.Send(msg);

            // Освобождаем сокет
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
            return;
        }
    }
}
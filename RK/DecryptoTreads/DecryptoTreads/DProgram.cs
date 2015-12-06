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

namespace Client
{
    class Client
    {
        static String pathOutput = "";
        static String name;

        static byte[] iv;
        static byte[] key;
        static byte[] mainArray;

        static long count = 0;
        
        static void Main(string[] args)
        {
            try
            {
                // Назначаем сокет локальной конечной точке и слушаем входящие сокеты
                // Устанавливаем для сокета локальную конечную точку
                IPHostEntry  ipHost = Dns.GetHostEntry("localhost");
                IPAddress    ipAddr = ipHost.AddressList[0];
                IPEndPoint   ipEndPoint = new IPEndPoint(ipAddr, 11000);
                // Создаем сокет Tcp/Ip
                Socket sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                sListener.Bind(ipEndPoint);
                while (true) 
                {
                    sListener.Listen(10);
                    // Начинаем слушать соединения
                    Console.WriteLine("Ожидаем соединение через порт {0}\n", ipEndPoint);
                    // Программа приостанавливается, ожидая входящее соединение
                    Socket handler = sListener.Accept();
                    // Мы дождались клиента, пытающегося с нами соединиться

                    //Получаем вектор инициализации
                    byte[] bytes = new byte[16];
                    int bytesRec = handler.Receive(bytes);
                    iv = bytes;
                    // Отправляем ответ клиенту
                    string reply = "Вектор получен";
                    byte[] msg = Encoding.UTF8.GetBytes(reply);
                    handler.Send(msg);

                    //Получаем ключ
                    bytes = new byte[32];
                    bytesRec = handler.Receive(bytes);
                    key = bytes;
                    // Отправляем ответ клиенту
                    reply = "Ключ получен";
                    msg = Encoding.UTF8.GetBytes(reply);
                    handler.Send(msg);

                    //Получаем длину потока
                    byte[] countArr = BitConverter.GetBytes(count);
                    bytesRec = handler.Receive(countArr);
                    count = BitConverter.ToInt32(countArr, 0);
                    // Отправляем ответ клиенту
                    reply = "Длина получена";
                    msg = Encoding.UTF8.GetBytes(reply);
                    handler.Send(msg);

                    //Получаем имя файла
                    byte[] nameArr = new byte[1024];
                    bytesRec = handler.Receive(nameArr);
                    name = Encoding.UTF8.GetString(nameArr, 0, bytesRec);
                    // Отправляем ответ клиенту
                    reply = "Имя получено";
                    msg = Encoding.UTF8.GetBytes(reply);
                    handler.Send(msg);

                    //Принемаем поток
                    bytes = new byte[count];
                    bytesRec = handler.Receive(bytes);

                    mainArray = bytes;

                    DecryptFile(mainArray, pathOutput + name, key, iv);
                    Thread.Sleep(500);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void DecryptFile(byte[] mainArray, string outputFile, byte[] key, byte[] iv)
        {
            try
            {
                if (mainArray != null)
                {
                    using (RijndaelManaged aes = new RijndaelManaged())
                    {
                        aes.Key = key;
                        aes.IV = iv;
                        using (ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                        {
                            using (CryptoStream cs = new CryptoStream(new MemoryStream(mainArray, false), decryptor, CryptoStreamMode.Read))
                            {
                                using (FileStream fsOut = new FileStream(outputFile, FileMode.Create))
                                {
                                    int data;
                                    while ((data = cs.ReadByte()) != -1)
                                    {
                                        fsOut.WriteByte((byte)data);
                                    }
                                }
                            }
                        }
                    }
                    Console.WriteLine(" Выполнена расшифровка файла!");
                }
                else { Console.WriteLine(" Пустая строка!"); }
            }
            catch (Exception ex)
            {
                // failed to decrypt file
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

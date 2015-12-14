using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form
    {
        DataClassesDataContext dataContext = new DataClassesDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            var client_selected = from client in dataContext.Client select client;
            dataGridViewClient.DataSource = client_selected;

            var product_selected = from product in dataContext.Product select product;
            dataGridViewProduct.DataSource = product_selected;

            var employee_selected = from employee in dataContext.Employee select employee;
            dataGridViewEmployee.DataSource = employee_selected;

            var order_selected = from order in dataContext.Order select order;
            dataGridViewOrder.DataSource = order_selected;

            var ship_selected = from ship in dataContext.Shiping select ship;
            dataGridViewShipping.DataSource = ship_selected;

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.dataDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.dataDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.dataDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Shiping". При необходимости она может быть перемещена или удалена.
            this.shipingTableAdapter.Fill(this.dataDataSet.Shiping);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.dataDataSet.Order);

        }

        private void сохранитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dataContext.SubmitChanges();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            dataContext.SubmitChanges();
        }
    }
}

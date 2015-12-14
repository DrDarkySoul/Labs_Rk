namespace Lab_6
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageOrder = new System.Windows.Forms.TabPage();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new Lab_6.DataDataSet();
            this.tabPageShipping = new System.Windows.Forms.TabPage();
            this.dataGridViewShipping = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annotationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageProd = new System.Windows.Forms.TabPage();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new Lab_6.DataDataSetTableAdapters.OrderTableAdapter();
            this.shipingTableAdapter = new Lab_6.DataDataSetTableAdapters.ShipingTableAdapter();
            this.clientTableAdapter = new Lab_6.DataDataSetTableAdapters.ClientTableAdapter();
            this.employeeTableAdapter = new Lab_6.DataDataSetTableAdapters.EmployeeTableAdapter();
            this.productTableAdapter = new Lab_6.DataDataSetTableAdapters.ProductTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_save = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.tabPageShipping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShipping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipingBindingSource)).BeginInit();
            this.tabPageClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.tabPageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.tabPageProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageOrder);
            this.tabControl.Controls.Add(this.tabPageShipping);
            this.tabControl.Controls.Add(this.tabPageClients);
            this.tabControl.Controls.Add(this.tabPageEmployee);
            this.tabControl.Controls.Add(this.tabPageProd);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(866, 344);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageOrder
            // 
            this.tabPageOrder.Controls.Add(this.dataGridViewOrder);
            this.tabPageOrder.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrder.Name = "tabPageOrder";
            this.tabPageOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrder.Size = new System.Drawing.Size(858, 318);
            this.tabPageOrder.TabIndex = 0;
            this.tabPageOrder.Text = "Заказ";
            this.tabPageOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AutoGenerateColumns = false;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.shippingIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dataGridViewOrder.DataSource = this.orderBindingSource;
            this.dataGridViewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrder.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(852, 312);
            this.dataGridViewOrder.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // shippingIdDataGridViewTextBoxColumn
            // 
            this.shippingIdDataGridViewTextBoxColumn.DataPropertyName = "shippingId";
            this.shippingIdDataGridViewTextBoxColumn.HeaderText = "shippingId";
            this.shippingIdDataGridViewTextBoxColumn.Name = "shippingIdDataGridViewTextBoxColumn";
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "productId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "productId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "DataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPageShipping
            // 
            this.tabPageShipping.Controls.Add(this.dataGridViewShipping);
            this.tabPageShipping.Location = new System.Drawing.Point(4, 22);
            this.tabPageShipping.Name = "tabPageShipping";
            this.tabPageShipping.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShipping.Size = new System.Drawing.Size(858, 318);
            this.tabPageShipping.TabIndex = 1;
            this.tabPageShipping.Text = "Условия доставки";
            this.tabPageShipping.UseVisualStyleBackColor = true;
            // 
            // dataGridViewShipping
            // 
            this.dataGridViewShipping.AutoGenerateColumns = false;
            this.dataGridViewShipping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShipping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.shipDateDataGridViewTextBoxColumn,
            this.clientIdDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerAdressDataGridViewTextBoxColumn});
            this.dataGridViewShipping.DataSource = this.shipingBindingSource;
            this.dataGridViewShipping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShipping.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewShipping.Name = "dataGridViewShipping";
            this.dataGridViewShipping.Size = new System.Drawing.Size(852, 312);
            this.dataGridViewShipping.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // shipDateDataGridViewTextBoxColumn
            // 
            this.shipDateDataGridViewTextBoxColumn.DataPropertyName = "shipDate";
            this.shipDateDataGridViewTextBoxColumn.HeaderText = "shipDate";
            this.shipDateDataGridViewTextBoxColumn.Name = "shipDateDataGridViewTextBoxColumn";
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "clientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "clientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "employeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "employeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "paymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "paymentDate";
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "customerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // customerAdressDataGridViewTextBoxColumn
            // 
            this.customerAdressDataGridViewTextBoxColumn.DataPropertyName = "customerAdress";
            this.customerAdressDataGridViewTextBoxColumn.HeaderText = "customerAdress";
            this.customerAdressDataGridViewTextBoxColumn.Name = "customerAdressDataGridViewTextBoxColumn";
            // 
            // shipingBindingSource
            // 
            this.shipingBindingSource.DataMember = "Shiping";
            this.shipingBindingSource.DataSource = this.dataDataSet;
            // 
            // tabPageClients
            // 
            this.tabPageClients.Controls.Add(this.dataGridViewClient);
            this.tabPageClients.Location = new System.Drawing.Point(4, 22);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(858, 318);
            this.tabPageClients.TabIndex = 2;
            this.tabPageClients.Text = "Клиенты";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AutoGenerateColumns = false;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.contractNumberDataGridViewTextBoxColumn,
            this.annotationDataGridViewTextBoxColumn});
            this.dataGridViewClient.DataSource = this.clientBindingSource;
            this.dataGridViewClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClient.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.Size = new System.Drawing.Size(852, 312);
            this.dataGridViewClient.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // contractNumberDataGridViewTextBoxColumn
            // 
            this.contractNumberDataGridViewTextBoxColumn.DataPropertyName = "contractNumber";
            this.contractNumberDataGridViewTextBoxColumn.HeaderText = "contractNumber";
            this.contractNumberDataGridViewTextBoxColumn.Name = "contractNumberDataGridViewTextBoxColumn";
            // 
            // annotationDataGridViewTextBoxColumn
            // 
            this.annotationDataGridViewTextBoxColumn.DataPropertyName = "annotation";
            this.annotationDataGridViewTextBoxColumn.HeaderText = "annotation";
            this.annotationDataGridViewTextBoxColumn.Name = "annotationDataGridViewTextBoxColumn";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dataDataSet;
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.Controls.Add(this.dataGridViewEmployee);
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee.Size = new System.Drawing.Size(858, 318);
            this.tabPageEmployee.TabIndex = 3;
            this.tabPageEmployee.Text = "Работники";
            this.tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AutoGenerateColumns = false;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.lastNameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.positionDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1});
            this.dataGridViewEmployee.DataSource = this.employeeBindingSource;
            this.dataGridViewEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.Size = new System.Drawing.Size(852, 312);
            this.dataGridViewEmployee.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "birthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "birthDate";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn1
            // 
            this.adressDataGridViewTextBoxColumn1.DataPropertyName = "adress";
            this.adressDataGridViewTextBoxColumn1.HeaderText = "adress";
            this.adressDataGridViewTextBoxColumn1.Name = "adressDataGridViewTextBoxColumn1";
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dataDataSet;
            // 
            // tabPageProd
            // 
            this.tabPageProd.Controls.Add(this.dataGridViewProduct);
            this.tabPageProd.Location = new System.Drawing.Point(4, 22);
            this.tabPageProd.Name = "tabPageProd";
            this.tabPageProd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProd.Size = new System.Drawing.Size(858, 318);
            this.tabPageProd.TabIndex = 4;
            this.tabPageProd.Text = "Товар";
            this.tabPageProd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AutoGenerateColumns = false;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn4,
            this.brendDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn1,
            this.presentCountDataGridViewTextBoxColumn});
            this.dataGridViewProduct.DataSource = this.productBindingSource;
            this.dataGridViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProduct.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.Size = new System.Drawing.Size(852, 312);
            this.dataGridViewProduct.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn4
            // 
            this.idDataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn4.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn4.Name = "idDataGridViewTextBoxColumn4";
            // 
            // brendDataGridViewTextBoxColumn
            // 
            this.brendDataGridViewTextBoxColumn.DataPropertyName = "brend";
            this.brendDataGridViewTextBoxColumn.HeaderText = "brend";
            this.brendDataGridViewTextBoxColumn.Name = "brendDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // presentCountDataGridViewTextBoxColumn
            // 
            this.presentCountDataGridViewTextBoxColumn.DataPropertyName = "presentCount";
            this.presentCountDataGridViewTextBoxColumn.HeaderText = "presentCount";
            this.presentCountDataGridViewTextBoxColumn.Name = "presentCountDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSetBindingSource
            // 
            this.dataDataSetBindingSource.DataSource = this.dataDataSet;
            this.dataDataSetBindingSource.Position = 0;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // shipingTableAdapter
            // 
            this.shipingTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 26);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click_1);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(796, 362);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 391);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Форма заказа";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabControl.ResumeLayout(false);
            this.tabPageOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.tabPageShipping.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShipping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipingBindingSource)).EndInit();
            this.tabPageClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.tabPageEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.tabPageProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageOrder;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.BindingSource dataDataSetBindingSource;
        private DataDataSet dataDataSet;
        private System.Windows.Forms.TabPage tabPageShipping;
        private System.Windows.Forms.DataGridView dataGridViewShipping;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.TabPage tabPageEmployee;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.TabPage tabPageProd;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private DataDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource shipingBindingSource;
        private DataDataSetTableAdapters.ShipingTableAdapter shipingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annotationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DataDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn brendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Button button_save;
    }
}


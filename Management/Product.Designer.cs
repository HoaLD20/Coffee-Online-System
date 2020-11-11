namespace Management
{
    partial class Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cOFFEEDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOFFEEDataSet2 = new Management.COFFEEDataSet2();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cOFFEEDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.productTableAdapter = new Management.COFFEEDataSet2TableAdapters.ProductTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbProduct = new System.Windows.Forms.DataGridView();
            this.IDProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbAvailable = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.txtDescripton = new System.Windows.Forms.TextBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.txtNamePro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDPro = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOFFEEDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOFFEEDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOFFEEDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1676, 763);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1676, 763);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1684, 792);
            this.tabControl1.TabIndex = 0;
            // 
            // cOFFEEDataSet2
            // 
            this.cOFFEEDataSet2.DataSetName = "COFFEEDataSet2";
            this.cOFFEEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.bntAdd);
            this.groupBox2.Controls.Add(this.bntDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(1395, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 361);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(21, 282);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 52);
            this.button1.TabIndex = 30;
            this.button1.Text = "Refresh ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bntAdd
            // 
            this.bntAdd.Image = ((System.Drawing.Image)(resources.GetObject("bntAdd.Image")));
            this.bntAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntAdd.Location = new System.Drawing.Point(21, 35);
            this.bntAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(188, 50);
            this.bntAdd.TabIndex = 16;
            this.bntAdd.Text = "Add Product ";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click_1);
            // 
            // bntDelete
            // 
            this.bntDelete.Image = ((System.Drawing.Image)(resources.GetObject("bntDelete.Image")));
            this.bntDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntDelete.Location = new System.Drawing.Point(21, 205);
            this.bntDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(188, 50);
            this.bntDelete.TabIndex = 19;
            this.bntDelete.Text = "Delete Product";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(21, 127);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 44);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update Product";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.tbProduct);
            this.groupBox3.Location = new System.Drawing.Point(58, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1315, 355);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List of products";
            // 
            // tbProduct
            // 
            this.tbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProduct,
            this.IDCategory,
            this.nameProduct,
            this.available,
            this.price,
            this.description,
            this.status,
            this.imageUrl,
            this.photo});
            this.tbProduct.Location = new System.Drawing.Point(6, 21);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.RowHeadersWidth = 51;
            this.tbProduct.RowTemplate.Height = 100;
            this.tbProduct.Size = new System.Drawing.Size(1282, 328);
            this.tbProduct.TabIndex = 0;
            this.tbProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbProduct_CellClick_1);
            // 
            // IDProduct
            // 
            this.IDProduct.DataPropertyName = "IDProduct";
            this.IDProduct.HeaderText = "IDProduct";
            this.IDProduct.MinimumWidth = 6;
            this.IDProduct.Name = "IDProduct";
            this.IDProduct.ReadOnly = true;
            this.IDProduct.Width = 125;
            // 
            // IDCategory
            // 
            this.IDCategory.DataPropertyName = "IDCategory";
            this.IDCategory.HeaderText = "IDCategory";
            this.IDCategory.MinimumWidth = 6;
            this.IDCategory.Name = "IDCategory";
            this.IDCategory.Width = 125;
            // 
            // nameProduct
            // 
            this.nameProduct.DataPropertyName = "nameProduct";
            this.nameProduct.HeaderText = "nameProduct";
            this.nameProduct.MinimumWidth = 6;
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Width = 125;
            // 
            // available
            // 
            this.available.DataPropertyName = "available";
            this.available.HeaderText = "available";
            this.available.MinimumWidth = 6;
            this.available.Name = "available";
            this.available.Width = 125;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.Width = 125;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Visible = false;
            this.status.Width = 125;
            // 
            // imageUrl
            // 
            this.imageUrl.DataPropertyName = "imageUrl";
            this.imageUrl.HeaderText = "imageUrl";
            this.imageUrl.MinimumWidth = 6;
            this.imageUrl.Name = "imageUrl";
            this.imageUrl.Width = 125;
            // 
            // photo
            // 
            this.photo.DataPropertyName = "photo";
            this.photo.HeaderText = "photo";
            this.photo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.photo.MinimumWidth = 6;
            this.photo.Name = "photo";
            this.photo.Width = 250;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtURL);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbbAvailable);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.cbbCategory);
            this.groupBox1.Controls.Add(this.txtDescripton);
            this.groupBox1.Controls.Add(this.btnImage);
            this.groupBox1.Controls.Add(this.txtNamePro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtIDPro);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Location = new System.Drawing.Point(58, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1393, 301);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product details";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(943, 250);
            this.txtURL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(308, 22);
            this.txtURL.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(813, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "URL image";
            // 
            // cbbAvailable
            // 
            this.cbbAvailable.Location = new System.Drawing.Point(386, 171);
            this.cbbAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbAvailable.Name = "cbbAvailable";
            this.cbbAvailable.Size = new System.Drawing.Size(308, 22);
            this.cbbAvailable.TabIndex = 37;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(943, 95);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(308, 140);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 36;
            this.pictureBox.TabStop = false;
            // 
            // cbbCategory
            // 
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(386, 78);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(308, 24);
            this.cbbCategory.TabIndex = 34;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged_1);
            // 
            // txtDescripton
            // 
            this.txtDescripton.Location = new System.Drawing.Point(943, 14);
            this.txtDescripton.Name = "txtDescripton";
            this.txtDescripton.Size = new System.Drawing.Size(308, 22);
            this.txtDescripton.TabIndex = 33;
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(1267, 139);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(119, 43);
            this.btnImage.TabIndex = 31;
            this.btnImage.Text = "Browse";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click_1);
            // 
            // txtNamePro
            // 
            this.txtNamePro.Location = new System.Drawing.Point(386, 129);
            this.txtNamePro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamePro.Name = "txtNamePro";
            this.txtNamePro.Size = new System.Drawing.Size(308, 22);
            this.txtNamePro.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Product";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(904, 212);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 17);
            this.label13.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name product";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(1423, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 17);
            this.label14.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Available";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(1199, 43);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 17);
            this.label15.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(841, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(1131, 95);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 17);
            this.label16.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(847, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(1213, 139);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 17);
            this.label11.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(808, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(1213, 191);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID categogy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(1213, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(673, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 22;
            // 
            // txtIDPro
            // 
            this.txtIDPro.Location = new System.Drawing.Point(386, 32);
            this.txtIDPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDPro.Name = "txtIDPro";
            this.txtIDPro.Size = new System.Drawing.Size(308, 22);
            this.txtIDPro.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(943, 62);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(308, 22);
            this.txtPrice.TabIndex = 11;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1708, 816);
            this.Controls.Add(this.tabControl1);
            this.Name = "Product";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Product_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOFFEEDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOFFEEDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOFFEEDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private System.Windows.Forms.BindingSource cOFFEEDataSet2BindingSource;
        private COFFEEDataSet2 cOFFEEDataSet2;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource cOFFEEDataSet1BindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.ImageList imageList1;
        private COFFEEDataSet2TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView tbProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn available;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageUrl;
        private System.Windows.Forms.DataGridViewImageColumn photo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cbbAvailable;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.TextBox txtDescripton;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.TextBox txtNamePro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDPro;
        private System.Windows.Forms.TextBox txtPrice;
    }
}


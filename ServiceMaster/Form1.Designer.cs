namespace ServiceMaster
{
    partial class ServiceMaster
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceMaster));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.header = new System.Windows.Forms.Panel();
            this.Search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Minimaze = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.dockpanel = new System.Windows.Forms.Panel();
            this.save = new MaterialSkin.Controls.MaterialFlatButton();
            this.saveandprint = new MaterialSkin.Controls.MaterialFlatButton();
            this.Leftpanel = new System.Windows.Forms.Panel();
            this.allorder = new System.Windows.Forms.Button();
            this.neworder = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.complate = new System.Windows.Forms.Label();
            this.vidtext = new System.Windows.Forms.Label();
            this.nambellable = new System.Windows.Forms.Label();
            this.otherstextbox = new System.Windows.Forms.TextBox();
            this.otherslable = new System.Windows.Forms.Label();
            this.pricetextbox = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.komplistbox = new System.Windows.Forms.CheckedListBox();
            this.komplable = new System.Windows.Forms.Label();
            this.infolable = new System.Windows.Forms.Label();
            this.imeitextbox = new System.Windows.Forms.TextBox();
            this.imeiable = new System.Windows.Forms.Label();
            this.teltexbox = new System.Windows.Forms.TextBox();
            this.tellable = new System.Windows.Forms.Label();
            this.namelable = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.Замовлення = new System.Windows.Forms.Label();
            this.datenow = new System.Windows.Forms.TextBox();
            this.modeltextbox = new System.Windows.Forms.TextBox();
            this.modellable = new System.Windows.Forms.Label();
            this.lnamelable = new System.Windows.Forms.Label();
            this.lnametextbox = new System.Windows.Forms.TextBox();
            this.nesprlable = new System.Windows.Forms.Label();
            this.nesprtextbox = new System.Windows.Forms.TextBox();
            this.infolistchbox = new System.Windows.Forms.CheckedListBox();
            this.complateCHbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateView = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nespr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.testlable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.header.SuspendLayout();
            this.dockpanel.SuspendLayout();
            this.Leftpanel.SuspendLayout();
            this.Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateView)).BeginInit();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.MediumPurple;
            this.header.Controls.Add(this.testlable);
            this.header.Controls.Add(this.Search);
            this.header.Controls.Add(this.Minimaze);
            this.header.Controls.Add(this.close);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(125, 5);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(870, 57);
            this.header.TabIndex = 3;
            // 
            // Search
            // 
            this.Search.AllowDrop = true;
            this.Search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Search.Depth = 0;
            this.Search.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Search.Hint = "Пошук";
            this.Search.Location = new System.Drawing.Point(99, 16);
            this.Search.MaxLength = 32767;
            this.Search.MouseState = MaterialSkin.MouseState.HOVER;
            this.Search.Name = "Search";
            this.Search.PasswordChar = '\0';
            this.Search.SelectedText = "";
            this.Search.SelectionLength = 0;
            this.Search.SelectionStart = 0;
            this.Search.Size = new System.Drawing.Size(383, 23);
            this.Search.TabIndex = 0;
            this.Search.TabStop = false;
            this.Search.UseSystemPasswordChar = false;
            this.Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // Minimaze
            // 
            this.Minimaze.AutoSize = true;
            this.Minimaze.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimaze.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimaze.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Minimaze.Location = new System.Drawing.Point(805, 0);
            this.Minimaze.Name = "Minimaze";
            this.Minimaze.Padding = new System.Windows.Forms.Padding(0, 4, 4, 0);
            this.Minimaze.Size = new System.Drawing.Size(28, 34);
            this.Minimaze.TabIndex = 1;
            this.Minimaze.Text = "-";
            this.Minimaze.Click += new System.EventHandler(this.Minimaze_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close.Location = new System.Drawing.Point(833, 0);
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(0, 4, 4, 0);
            this.close.Size = new System.Drawing.Size(37, 34);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // dockpanel
            // 
            this.dockpanel.BackColor = System.Drawing.Color.White;
            this.dockpanel.Controls.Add(this.save);
            this.dockpanel.Controls.Add(this.saveandprint);
            this.dockpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockpanel.Location = new System.Drawing.Point(125, 553);
            this.dockpanel.Name = "dockpanel";
            this.dockpanel.Size = new System.Drawing.Size(870, 42);
            this.dockpanel.TabIndex = 4;
            this.dockpanel.Visible = false;
            // 
            // save
            // 
            this.save.AutoSize = true;
            this.save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save.BackColor = System.Drawing.Color.MediumPurple;
            this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.save.Depth = 0;
            this.save.Dock = System.Windows.Forms.DockStyle.Right;
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.save.Icon = null;
            this.save.Location = new System.Drawing.Point(624, 0);
            this.save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.save.MouseState = MaterialSkin.MouseState.HOVER;
            this.save.Name = "save";
            this.save.Primary = false;
            this.save.Size = new System.Drawing.Size(88, 42);
            this.save.TabIndex = 13;
            this.save.Text = "Зберегти";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // saveandprint
            // 
            this.saveandprint.AutoSize = true;
            this.saveandprint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveandprint.Depth = 0;
            this.saveandprint.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveandprint.Icon = null;
            this.saveandprint.Location = new System.Drawing.Point(712, 0);
            this.saveandprint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveandprint.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveandprint.Name = "saveandprint";
            this.saveandprint.Primary = false;
            this.saveandprint.Size = new System.Drawing.Size(158, 42);
            this.saveandprint.TabIndex = 12;
            this.saveandprint.Text = "Друк і збереження";
            this.saveandprint.UseVisualStyleBackColor = true;
            this.saveandprint.Click += new System.EventHandler(this.printandsave_Click);
            // 
            // Leftpanel
            // 
            this.Leftpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Leftpanel.Controls.Add(this.allorder);
            this.Leftpanel.Controls.Add(this.neworder);
            this.Leftpanel.Controls.Add(this.Logo);
            this.Leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Leftpanel.Location = new System.Drawing.Point(5, 5);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Size = new System.Drawing.Size(120, 590);
            this.Leftpanel.TabIndex = 5;
            // 
            // allorder
            // 
            this.allorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.allorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.allorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.allorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.allorder.Location = new System.Drawing.Point(0, 119);
            this.allorder.Name = "allorder";
            this.allorder.Size = new System.Drawing.Size(120, 62);
            this.allorder.TabIndex = 2;
            this.allorder.Text = "Всі замовлення";
            this.allorder.UseVisualStyleBackColor = true;
            this.allorder.Click += new System.EventHandler(this.allorder_Click);
            // 
            // neworder
            // 
            this.neworder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.neworder.Dock = System.Windows.Forms.DockStyle.Top;
            this.neworder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.neworder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.neworder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.neworder.Location = new System.Drawing.Point(0, 57);
            this.neworder.Name = "neworder";
            this.neworder.Size = new System.Drawing.Size(120, 62);
            this.neworder.TabIndex = 1;
            this.neworder.Text = "Нове замовлення";
            this.neworder.UseVisualStyleBackColor = true;
            this.neworder.Click += new System.EventHandler(this.neworder_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.DarkViolet;
            this.Logo.Controls.Add(this.pictureBox1);
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(120, 57);
            this.Logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(872, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.complate, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.vidtext, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.nambellable, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.otherstextbox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.otherslable, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.pricetextbox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.price, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.komplistbox, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.komplable, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.infolable, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.imeitextbox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.imeiable, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.teltexbox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tellable, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.namelable, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nametextbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Замовлення, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.datenow, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.modeltextbox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.modellable, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lnamelable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lnametextbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nesprlable, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.nesprtextbox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.infolistchbox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.complateCHbox, 3, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.30247F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.30247F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.30247F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.30247F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.30247F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.30247F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.18519F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(866, 454);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // complate
            // 
            this.complate.AutoSize = true;
            this.complate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.complate.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.complate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.complate.Location = new System.Drawing.Point(435, 394);
            this.complate.Name = "complate";
            this.complate.Size = new System.Drawing.Size(210, 60);
            this.complate.TabIndex = 23;
            this.complate.Text = "Готово";
            this.complate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vidtext
            // 
            this.vidtext.AutoSize = true;
            this.vidtext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vidtext.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vidtext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vidtext.Location = new System.Drawing.Point(435, 0);
            this.vidtext.Name = "vidtext";
            this.vidtext.Size = new System.Drawing.Size(210, 40);
            this.vidtext.TabIndex = 21;
            this.vidtext.Text = "від";
            this.vidtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nambellable
            // 
            this.nambellable.AutoSize = true;
            this.nambellable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nambellable.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nambellable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nambellable.Location = new System.Drawing.Point(219, 0);
            this.nambellable.Name = "nambellable";
            this.nambellable.Size = new System.Drawing.Size(210, 40);
            this.nambellable.TabIndex = 20;
            this.nambellable.Text = "--";
            this.nambellable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // otherstextbox
            // 
            this.otherstextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otherstextbox.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otherstextbox.Location = new System.Drawing.Point(219, 338);
            this.otherstextbox.Multiline = true;
            this.otherstextbox.Name = "otherstextbox";
            this.otherstextbox.Size = new System.Drawing.Size(210, 53);
            this.otherstextbox.TabIndex = 9;
            this.otherstextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // otherslable
            // 
            this.otherslable.AutoSize = true;
            this.otherslable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otherslable.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otherslable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.otherslable.Location = new System.Drawing.Point(3, 335);
            this.otherslable.Name = "otherslable";
            this.otherslable.Size = new System.Drawing.Size(210, 59);
            this.otherslable.TabIndex = 19;
            this.otherslable.Text = "Примітки";
            this.otherslable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pricetextbox
            // 
            this.pricetextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pricetextbox.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pricetextbox.Location = new System.Drawing.Point(219, 397);
            this.pricetextbox.Multiline = true;
            this.pricetextbox.Name = "pricetextbox";
            this.pricetextbox.Size = new System.Drawing.Size(210, 54);
            this.pricetextbox.TabIndex = 10;
            this.pricetextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.price.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.price.Location = new System.Drawing.Point(3, 394);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(210, 60);
            this.price.TabIndex = 17;
            this.price.Text = "Сума";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // komplistbox
            // 
            this.komplistbox.CheckOnClick = true;
            this.komplistbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.komplistbox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.komplistbox.FormattingEnabled = true;
            this.komplistbox.IntegralHeight = false;
            this.komplistbox.Location = new System.Drawing.Point(651, 279);
            this.komplistbox.Name = "komplistbox";
            this.tableLayoutPanel1.SetRowSpan(this.komplistbox, 2);
            this.komplistbox.Size = new System.Drawing.Size(212, 112);
            this.komplistbox.TabIndex = 8;
            // 
            // komplable
            // 
            this.komplable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.komplable.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.komplable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.komplable.Location = new System.Drawing.Point(435, 276);
            this.komplable.Name = "komplable";
            this.tableLayoutPanel1.SetRowSpan(this.komplable, 2);
            this.komplable.Size = new System.Drawing.Size(210, 118);
            this.komplable.TabIndex = 15;
            this.komplable.Text = "Комплектація";
            this.komplable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infolable
            // 
            this.infolable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infolable.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infolable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.infolable.Location = new System.Drawing.Point(435, 158);
            this.infolable.Name = "infolable";
            this.tableLayoutPanel1.SetRowSpan(this.infolable, 2);
            this.infolable.Size = new System.Drawing.Size(210, 118);
            this.infolable.TabIndex = 13;
            this.infolable.Text = "Опис";
            this.infolable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imeitextbox
            // 
            this.imeitextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imeitextbox.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imeitextbox.Location = new System.Drawing.Point(219, 279);
            this.imeitextbox.Multiline = true;
            this.imeitextbox.Name = "imeitextbox";
            this.imeitextbox.Size = new System.Drawing.Size(210, 53);
            this.imeitextbox.TabIndex = 5;
            this.imeitextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imeiable
            // 
            this.imeiable.AutoSize = true;
            this.imeiable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imeiable.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imeiable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imeiable.Location = new System.Drawing.Point(3, 276);
            this.imeiable.Name = "imeiable";
            this.imeiable.Size = new System.Drawing.Size(210, 59);
            this.imeiable.TabIndex = 11;
            this.imeiable.Text = "IMEI(S/N)";
            this.imeiable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teltexbox
            // 
            this.teltexbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teltexbox.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teltexbox.Location = new System.Drawing.Point(219, 161);
            this.teltexbox.Multiline = true;
            this.teltexbox.Name = "teltexbox";
            this.teltexbox.Size = new System.Drawing.Size(210, 53);
            this.teltexbox.TabIndex = 3;
            this.teltexbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tellable
            // 
            this.tellable.AutoSize = true;
            this.tellable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tellable.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tellable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tellable.Location = new System.Drawing.Point(3, 158);
            this.tellable.Name = "tellable";
            this.tellable.Size = new System.Drawing.Size(210, 59);
            this.tellable.TabIndex = 9;
            this.tellable.Text = "Телефон";
            this.tellable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // namelable
            // 
            this.namelable.AutoSize = true;
            this.namelable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namelable.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namelable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.namelable.Location = new System.Drawing.Point(3, 99);
            this.namelable.Name = "namelable";
            this.namelable.Size = new System.Drawing.Size(210, 59);
            this.namelable.TabIndex = 7;
            this.namelable.Text = "Ім\'я";
            this.namelable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nametextbox
            // 
            this.nametextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nametextbox.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nametextbox.Location = new System.Drawing.Point(219, 102);
            this.nametextbox.Multiline = true;
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(210, 53);
            this.nametextbox.TabIndex = 2;
            this.nametextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Замовлення
            // 
            this.Замовлення.AutoSize = true;
            this.Замовлення.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Замовлення.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Замовлення.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Замовлення.Location = new System.Drawing.Point(3, 0);
            this.Замовлення.Name = "Замовлення";
            this.Замовлення.Size = new System.Drawing.Size(210, 40);
            this.Замовлення.TabIndex = 0;
            this.Замовлення.Text = "Замовлення №";
            this.Замовлення.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datenow
            // 
            this.datenow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datenow.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datenow.Location = new System.Drawing.Point(651, 3);
            this.datenow.Name = "datenow";
            this.datenow.Size = new System.Drawing.Size(212, 34);
            this.datenow.TabIndex = 0;
            this.datenow.TabStop = false;
            this.datenow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modeltextbox
            // 
            this.modeltextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modeltextbox.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeltextbox.Location = new System.Drawing.Point(219, 220);
            this.modeltextbox.Multiline = true;
            this.modeltextbox.Name = "modeltextbox";
            this.modeltextbox.Size = new System.Drawing.Size(210, 53);
            this.modeltextbox.TabIndex = 4;
            this.modeltextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modellable
            // 
            this.modellable.AutoSize = true;
            this.modellable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modellable.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modellable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modellable.Location = new System.Drawing.Point(3, 217);
            this.modellable.Name = "modellable";
            this.modellable.Size = new System.Drawing.Size(210, 59);
            this.modellable.TabIndex = 1;
            this.modellable.Text = "Модель";
            this.modellable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnamelable
            // 
            this.lnamelable.AutoSize = true;
            this.lnamelable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnamelable.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnamelable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lnamelable.Location = new System.Drawing.Point(3, 40);
            this.lnamelable.Name = "lnamelable";
            this.lnamelable.Size = new System.Drawing.Size(210, 59);
            this.lnamelable.TabIndex = 5;
            this.lnamelable.Text = "Прізвище";
            this.lnamelable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnametextbox
            // 
            this.lnametextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnametextbox.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnametextbox.Location = new System.Drawing.Point(219, 43);
            this.lnametextbox.Multiline = true;
            this.lnametextbox.Name = "lnametextbox";
            this.lnametextbox.Size = new System.Drawing.Size(210, 53);
            this.lnametextbox.TabIndex = 1;
            this.lnametextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nesprlable
            // 
            this.nesprlable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nesprlable.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nesprlable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nesprlable.Location = new System.Drawing.Point(435, 40);
            this.nesprlable.Name = "nesprlable";
            this.tableLayoutPanel1.SetRowSpan(this.nesprlable, 2);
            this.nesprlable.Size = new System.Drawing.Size(210, 118);
            this.nesprlable.TabIndex = 3;
            this.nesprlable.Text = "Несправність";
            this.nesprlable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nesprtextbox
            // 
            this.nesprtextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nesprtextbox.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nesprtextbox.Location = new System.Drawing.Point(651, 43);
            this.nesprtextbox.Multiline = true;
            this.nesprtextbox.Name = "nesprtextbox";
            this.tableLayoutPanel1.SetRowSpan(this.nesprtextbox, 2);
            this.nesprtextbox.Size = new System.Drawing.Size(212, 112);
            this.nesprtextbox.TabIndex = 6;
            this.nesprtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // infolistchbox
            // 
            this.infolistchbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infolistchbox.CheckOnClick = true;
            this.infolistchbox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infolistchbox.FormattingEnabled = true;
            this.infolistchbox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.infolistchbox.IntegralHeight = false;
            this.infolistchbox.Location = new System.Drawing.Point(651, 161);
            this.infolistchbox.Name = "infolistchbox";
            this.tableLayoutPanel1.SetRowSpan(this.infolistchbox, 2);
            this.infolistchbox.Size = new System.Drawing.Size(212, 112);
            this.infolistchbox.Sorted = true;
            this.infolistchbox.TabIndex = 7;
            this.infolistchbox.ThreeDCheckBoxes = true;
            // 
            // complateCHbox
            // 
            this.complateCHbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.complateCHbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.complateCHbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.complateCHbox.Checked = false;
            this.complateCHbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.complateCHbox.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complateCHbox.ForeColor = System.Drawing.Color.White;
            this.complateCHbox.Location = new System.Drawing.Point(747, 414);
            this.complateCHbox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.complateCHbox.MaximumSize = new System.Drawing.Size(50, 50);
            this.complateCHbox.Name = "complateCHbox";
            this.complateCHbox.Size = new System.Drawing.Size(20, 20);
            this.complateCHbox.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.dateView);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(862, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // dateView
            // 
            this.dateView.AllowUserToAddRows = false;
            this.dateView.AllowUserToDeleteRows = false;
            this.dateView.AllowUserToResizeColumns = false;
            this.dateView.AllowUserToResizeRows = false;
            this.dateView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dateView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dateView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dateView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dateView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dateView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dateView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Model,
            this.nespr,
            this.Lname,
            this.name,
            this.statys});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dateView.DefaultCellStyle = dataGridViewCellStyle8;
            this.dateView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateView.EnableHeadersVisualStyles = false;
            this.dateView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dateView.Location = new System.Drawing.Point(3, 3);
            this.dateView.MultiSelect = false;
            this.dateView.Name = "dateView";
            this.dateView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dateView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dateView.RowHeadersVisible = false;
            this.dateView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dateView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dateView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dateView.RowTemplate.Height = 30;
            this.dateView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dateView.ShowCellErrors = false;
            this.dateView.ShowCellToolTips = false;
            this.dateView.ShowEditingIcon = false;
            this.dateView.ShowRowErrors = false;
            this.dateView.Size = new System.Drawing.Size(856, 444);
            this.dateView.Style = MetroFramework.MetroColorStyle.Purple;
            this.dateView.TabIndex = 7;
            this.dateView.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dateView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dateView_CellDoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.HeaderText = "№";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // Model
            // 
            this.Model.HeaderText = "Модель";
            this.Model.MinimumWidth = 100;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // nespr
            // 
            this.nespr.HeaderText = "Несправність";
            this.nespr.MinimumWidth = 100;
            this.nespr.Name = "nespr";
            this.nespr.ReadOnly = true;
            // 
            // Lname
            // 
            this.Lname.HeaderText = "Прізвище";
            this.Lname.MinimumWidth = 100;
            this.Lname.Name = "Lname";
            this.Lname.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Ім\'я";
            this.name.MinimumWidth = 100;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // statys
            // 
            this.statys.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.statys.HeaderText = "Статус";
            this.statys.Name = "statys";
            this.statys.ReadOnly = true;
            this.statys.Width = 120;
            // 
            // TabControl
            // 
            this.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Depth = 0;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.ItemSize = new System.Drawing.Size(58, 0);
            this.TabControl.Location = new System.Drawing.Point(125, 62);
            this.TabControl.Margin = new System.Windows.Forms.Padding(0);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(0, 0);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(870, 491);
            this.TabControl.TabIndex = 1;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // testlable
            // 
            this.testlable.AutoSize = true;
            this.testlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testlable.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.testlable.Location = new System.Drawing.Point(629, 16);
            this.testlable.Name = "testlable";
            this.testlable.Size = new System.Drawing.Size(0, 25);
            this.testlable.TabIndex = 2;
            this.testlable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServiceMaster
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.dockpanel);
            this.Controls.Add(this.header);
            this.Controls.Add(this.Leftpanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiceMaster";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceMaster";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.dockpanel.ResumeLayout(false);
            this.dockpanel.PerformLayout();
            this.Leftpanel.ResumeLayout(false);
            this.Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateView)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel dockpanel;
        private System.Windows.Forms.Label Minimaze;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Panel Leftpanel;
        private System.Windows.Forms.Panel Logo;
        private MaterialSkin.Controls.MaterialSingleLineTextField Search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button allorder;
        private MaterialSkin.Controls.MaterialFlatButton saveandprint;
        private MaterialSkin.Controls.MaterialFlatButton save;
        private System.Windows.Forms.Button neworder;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label complate;
        private System.Windows.Forms.Label vidtext;
        private System.Windows.Forms.Label nambellable;
        private System.Windows.Forms.TextBox otherstextbox;
        private System.Windows.Forms.Label otherslable;
        private System.Windows.Forms.TextBox pricetextbox;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.CheckedListBox komplistbox;
        private System.Windows.Forms.Label komplable;
        private System.Windows.Forms.Label infolable;
        private System.Windows.Forms.TextBox imeitextbox;
        private System.Windows.Forms.Label imeiable;
        private System.Windows.Forms.TextBox teltexbox;
        private System.Windows.Forms.Label tellable;
        private System.Windows.Forms.Label namelable;
        private System.Windows.Forms.TextBox nametextbox;
        public System.Windows.Forms.Label Замовлення;
        private System.Windows.Forms.TextBox datenow;
        private System.Windows.Forms.TextBox modeltextbox;
        private System.Windows.Forms.Label modellable;
        private System.Windows.Forms.Label lnamelable;
        private System.Windows.Forms.TextBox lnametextbox;
        private System.Windows.Forms.Label nesprlable;
        private System.Windows.Forms.TextBox nesprtextbox;
        private System.Windows.Forms.CheckedListBox infolistchbox;
        private Bunifu.Framework.UI.BunifuCheckbox complateCHbox;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroFramework.Controls.MetroGrid dateView;
        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn nespr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn statys;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel testlable;
    }
}


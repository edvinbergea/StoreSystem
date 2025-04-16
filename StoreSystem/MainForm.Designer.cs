namespace StoreSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Lager = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MoviePanel = new System.Windows.Forms.Panel();
            this.MoviesDataGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.MovieAddButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MovieDeleteButton = new System.Windows.Forms.Button();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.GamesDataGrid = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.GameAddButton = new System.Windows.Forms.Button();
            this.GameDeleteButton = new System.Windows.Forms.Button();
            this.BookPanel = new System.Windows.Forms.Panel();
            this.BooksDataGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BookAddButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BookDeleteButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddDeliveryButton = new System.Windows.Forms.ToolStripButton();
            this.Kassa = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.Productpanel = new System.Windows.Forms.Panel();
            this.KassaProdDataGrid = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.BuyButton = new System.Windows.Forms.Button();
            this.CartPanel = new System.Windows.Forms.Panel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.Lager.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MoviePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesDataGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamesDataGrid)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.BookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.Kassa.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Productpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KassaProdDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Lager);
            this.tabControl1.Controls.Add(this.Kassa);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 548);
            this.tabControl1.TabIndex = 0;
            // 
            // Lager
            // 
            this.Lager.Controls.Add(this.panel1);
            this.Lager.Controls.Add(this.toolStrip1);
            this.Lager.Location = new System.Drawing.Point(4, 22);
            this.Lager.Name = "Lager";
            this.Lager.Padding = new System.Windows.Forms.Padding(3);
            this.Lager.Size = new System.Drawing.Size(1004, 522);
            this.Lager.TabIndex = 0;
            this.Lager.Text = "Lager";
            this.Lager.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.MoviePanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.GamePanel);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.BookPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 491);
            this.panel1.TabIndex = 1;
            // 
            // MoviePanel
            // 
            this.MoviePanel.Controls.Add(this.MoviesDataGrid);
            this.MoviePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MoviePanel.Location = new System.Drawing.Point(0, 290);
            this.MoviePanel.Name = "MoviePanel";
            this.MoviePanel.Size = new System.Drawing.Size(998, 100);
            this.MoviePanel.TabIndex = 16;
            // 
            // MoviesDataGrid
            // 
            this.MoviesDataGrid.AllowUserToAddRows = false;
            this.MoviesDataGrid.AllowUserToDeleteRows = false;
            this.MoviesDataGrid.AllowUserToResizeRows = false;
            this.MoviesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MoviesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoviesDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviesDataGrid.Location = new System.Drawing.Point(0, 0);
            this.MoviesDataGrid.Name = "MoviesDataGrid";
            this.MoviesDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MoviesDataGrid.ShowEditingIcon = false;
            this.MoviesDataGrid.Size = new System.Drawing.Size(998, 100);
            this.MoviesDataGrid.TabIndex = 5;
            this.MoviesDataGrid.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(998, 30);
            this.panel3.TabIndex = 15;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel6.Controls.Add(this.MovieAddButton, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.MovieDeleteButton, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(998, 30);
            this.tableLayoutPanel6.TabIndex = 11;
            // 
            // MovieAddButton
            // 
            this.MovieAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieAddButton.Location = new System.Drawing.Point(841, 3);
            this.MovieAddButton.Name = "MovieAddButton";
            this.MovieAddButton.Size = new System.Drawing.Size(74, 24);
            this.MovieAddButton.TabIndex = 12;
            this.MovieAddButton.Text = "Lägg till";
            this.MovieAddButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(832, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Filmer";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MovieDeleteButton
            // 
            this.MovieDeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieDeleteButton.Location = new System.Drawing.Point(921, 3);
            this.MovieDeleteButton.Name = "MovieDeleteButton";
            this.MovieDeleteButton.Size = new System.Drawing.Size(74, 24);
            this.MovieDeleteButton.TabIndex = 13;
            this.MovieDeleteButton.Text = "Ta bort";
            this.MovieDeleteButton.UseVisualStyleBackColor = true;
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.GamesDataGrid);
            this.GamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GamePanel.Location = new System.Drawing.Point(0, 160);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(998, 100);
            this.GamePanel.TabIndex = 14;
            // 
            // GamesDataGrid
            // 
            this.GamesDataGrid.AllowUserToAddRows = false;
            this.GamesDataGrid.AllowUserToDeleteRows = false;
            this.GamesDataGrid.AllowUserToResizeRows = false;
            this.GamesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GamesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GamesDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamesDataGrid.Location = new System.Drawing.Point(0, 0);
            this.GamesDataGrid.Name = "GamesDataGrid";
            this.GamesDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GamesDataGrid.ShowEditingIcon = false;
            this.GamesDataGrid.Size = new System.Drawing.Size(998, 100);
            this.GamesDataGrid.TabIndex = 3;
            this.GamesDataGrid.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 130);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(998, 30);
            this.panel4.TabIndex = 13;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.GameAddButton, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.GameDeleteButton, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(998, 30);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(832, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Spel";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GameAddButton
            // 
            this.GameAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameAddButton.Location = new System.Drawing.Point(841, 3);
            this.GameAddButton.Name = "GameAddButton";
            this.GameAddButton.Size = new System.Drawing.Size(74, 24);
            this.GameAddButton.TabIndex = 7;
            this.GameAddButton.Text = "Lägg till";
            this.GameAddButton.UseVisualStyleBackColor = true;
            // 
            // GameDeleteButton
            // 
            this.GameDeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameDeleteButton.Location = new System.Drawing.Point(921, 3);
            this.GameDeleteButton.Name = "GameDeleteButton";
            this.GameDeleteButton.Size = new System.Drawing.Size(74, 24);
            this.GameDeleteButton.TabIndex = 8;
            this.GameDeleteButton.Text = "Ta bort";
            this.GameDeleteButton.UseVisualStyleBackColor = true;
            // 
            // BookPanel
            // 
            this.BookPanel.Controls.Add(this.BooksDataGrid);
            this.BookPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BookPanel.Location = new System.Drawing.Point(0, 30);
            this.BookPanel.Name = "BookPanel";
            this.BookPanel.Size = new System.Drawing.Size(998, 100);
            this.BookPanel.TabIndex = 12;
            // 
            // BooksDataGrid
            // 
            this.BooksDataGrid.AllowUserToAddRows = false;
            this.BooksDataGrid.AllowUserToDeleteRows = false;
            this.BooksDataGrid.AllowUserToResizeRows = false;
            this.BooksDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BooksDataGrid.Location = new System.Drawing.Point(0, 0);
            this.BooksDataGrid.Name = "BooksDataGrid";
            this.BooksDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BooksDataGrid.ShowEditingIcon = false;
            this.BooksDataGrid.Size = new System.Drawing.Size(998, 100);
            this.BooksDataGrid.TabIndex = 1;
            this.BooksDataGrid.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 30);
            this.panel2.TabIndex = 11;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.Controls.Add(this.BookAddButton, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.BookDeleteButton, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(998, 30);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // BookAddButton
            // 
            this.BookAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookAddButton.Location = new System.Drawing.Point(841, 3);
            this.BookAddButton.Name = "BookAddButton";
            this.BookAddButton.Size = new System.Drawing.Size(74, 24);
            this.BookAddButton.TabIndex = 6;
            this.BookAddButton.Text = "Lägg till";
            this.BookAddButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(832, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Böcker";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BookDeleteButton
            // 
            this.BookDeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookDeleteButton.Location = new System.Drawing.Point(921, 3);
            this.BookDeleteButton.Name = "BookDeleteButton";
            this.BookDeleteButton.Size = new System.Drawing.Size(74, 24);
            this.BookDeleteButton.TabIndex = 7;
            this.BookDeleteButton.Text = "Ta bort";
            this.BookDeleteButton.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(5);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDeliveryButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(998, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddDeliveryButton
            // 
            this.AddDeliveryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddDeliveryButton.Image = ((System.Drawing.Image)(resources.GetObject("AddDeliveryButton.Image")));
            this.AddDeliveryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddDeliveryButton.Name = "AddDeliveryButton";
            this.AddDeliveryButton.Size = new System.Drawing.Size(99, 22);
            this.AddDeliveryButton.Text = "Lägg till leverans";
            // 
            // Kassa
            // 
            this.Kassa.Controls.Add(this.tableLayoutPanel1);
            this.Kassa.Location = new System.Drawing.Point(4, 22);
            this.Kassa.Name = "Kassa";
            this.Kassa.Padding = new System.Windows.Forms.Padding(3);
            this.Kassa.Size = new System.Drawing.Size(1004, 522);
            this.Kassa.TabIndex = 1;
            this.Kassa.Text = "Kassa";
            this.Kassa.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(998, 516);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Productpanel);
            this.splitContainer1.Size = new System.Drawing.Size(690, 508);
            this.splitContainer1.SplitterDistance = 35;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produkter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Productpanel
            // 
            this.Productpanel.AutoScroll = true;
            this.Productpanel.Controls.Add(this.KassaProdDataGrid);
            this.Productpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Productpanel.Location = new System.Drawing.Point(0, 0);
            this.Productpanel.Name = "Productpanel";
            this.Productpanel.Size = new System.Drawing.Size(688, 467);
            this.Productpanel.TabIndex = 0;
            // 
            // KassaProdDataGrid
            // 
            this.KassaProdDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KassaProdDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KassaProdDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KassaProdDataGrid.Location = new System.Drawing.Point(0, 0);
            this.KassaProdDataGrid.Name = "KassaProdDataGrid";
            this.KassaProdDataGrid.ReadOnly = true;
            this.KassaProdDataGrid.Size = new System.Drawing.Size(688, 467);
            this.KassaProdDataGrid.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(701, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer2.Size = new System.Drawing.Size(293, 508);
            this.splitContainer2.SplitterDistance = 35;
            this.splitContainer2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kundvagn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.splitContainer3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.CartPanel, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(291, 467);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 430);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.TotalPriceLabel);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.BuyButton);
            this.splitContainer3.Size = new System.Drawing.Size(285, 34);
            this.splitContainer3.SplitterDistance = 128;
            this.splitContainer3.TabIndex = 0;
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalPriceLabel.Location = new System.Drawing.Point(0, 0);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(128, 34);
            this.TotalPriceLabel.TabIndex = 0;
            this.TotalPriceLabel.Text = "Totalt: 0 kr";
            this.TotalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuyButton
            // 
            this.BuyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuyButton.Location = new System.Drawing.Point(0, 0);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(153, 34);
            this.BuyButton.TabIndex = 0;
            this.BuyButton.Text = "Genomför köp";
            this.BuyButton.UseVisualStyleBackColor = true;
            // 
            // CartPanel
            // 
            this.CartPanel.AutoScroll = true;
            this.CartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartPanel.Location = new System.Drawing.Point(3, 3);
            this.CartPanel.Name = "CartPanel";
            this.CartPanel.Size = new System.Drawing.Size(285, 421);
            this.CartPanel.TabIndex = 1;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 23);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 548);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Affärssystem";
            this.tabControl1.ResumeLayout(false);
            this.Lager.ResumeLayout(false);
            this.Lager.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.MoviePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoviesDataGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.GamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GamesDataGrid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.BookPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Kassa.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Productpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KassaProdDataGrid)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Lager;
        private System.Windows.Forms.TabPage Kassa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Panel CartPanel;
        private System.Windows.Forms.Panel Productpanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView BooksDataGrid;
        private System.Windows.Forms.DataGridView MoviesDataGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GamesDataGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GameAddButton;
        private System.Windows.Forms.Button BookAddButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button MovieAddButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel BookPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Panel MoviePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button MovieDeleteButton;
        private System.Windows.Forms.Button GameDeleteButton;
        private System.Windows.Forms.Button BookDeleteButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton AddDeliveryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView KassaProdDataGrid;
    }
}


namespace SistemaBicicletas2019
{
    partial class FormMateriales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMateriales));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.TextBox_Buscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_NombreProvedor = new System.Windows.Forms.ComboBox();
            this.TextBox_CantidadMateriales = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_PrecioCompraMaterial = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox_IdMaterial = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_NombreMaterial = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_DescripcionMaterial = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvMaterialesAct = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvMaterialesInac = new System.Windows.Forms.DataGridView();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesAct)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesInac)).BeginInit();
            this.bunifuCards3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkCyan;
            this.bunifuCards1.Controls.Add(this.TextBox_Buscar);
            this.bunifuCards1.Controls.Add(this.panel2);
            this.bunifuCards1.Controls.Add(this.panel1);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(12, 12);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1340, 437);
            this.bunifuCards1.TabIndex = 4;
            // 
            // TextBox_Buscar
            // 
            this.TextBox_Buscar.BackColor = System.Drawing.Color.White;
            this.TextBox_Buscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_Buscar.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_Buscar.HintText = "Buscar por valor";
            this.TextBox_Buscar.isPassword = false;
            this.TextBox_Buscar.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextBox_Buscar.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_Buscar.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextBox_Buscar.LineThickness = 3;
            this.TextBox_Buscar.Location = new System.Drawing.Point(17, 345);
            this.TextBox_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Buscar.Name = "TextBox_Buscar";
            this.TextBox_Buscar.Size = new System.Drawing.Size(1033, 58);
            this.TextBox_Buscar.TabIndex = 15;
            this.TextBox_Buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_Buscar.OnValueChanged += new System.EventHandler(this.TextBox_Buscar_OnValueChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.comboBox_NombreProvedor);
            this.panel2.Controls.Add(this.TextBox_CantidadMateriales);
            this.panel2.Controls.Add(this.TextBox_PrecioCompraMaterial);
            this.panel2.Location = new System.Drawing.Point(464, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 282);
            this.panel2.TabIndex = 5;
            // 
            // comboBox_NombreProvedor
            // 
            this.comboBox_NombreProvedor.FormattingEnabled = true;
            this.comboBox_NombreProvedor.Location = new System.Drawing.Point(16, 223);
            this.comboBox_NombreProvedor.Name = "comboBox_NombreProvedor";
            this.comboBox_NombreProvedor.Size = new System.Drawing.Size(370, 28);
            this.comboBox_NombreProvedor.TabIndex = 4;
            // 
            // TextBox_CantidadMateriales
            // 
            this.TextBox_CantidadMateriales.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_CantidadMateriales.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_CantidadMateriales.ForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_CantidadMateriales.HintForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_CantidadMateriales.HintText = "Cantidad";
            this.TextBox_CantidadMateriales.isPassword = false;
            this.TextBox_CantidadMateriales.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.TextBox_CantidadMateriales.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextBox_CantidadMateriales.LineMouseHoverColor = System.Drawing.Color.DarkCyan;
            this.TextBox_CantidadMateriales.LineThickness = 3;
            this.TextBox_CantidadMateriales.Location = new System.Drawing.Point(16, 25);
            this.TextBox_CantidadMateriales.Margin = new System.Windows.Forms.Padding(6);
            this.TextBox_CantidadMateriales.Name = "TextBox_CantidadMateriales";
            this.TextBox_CantidadMateriales.Size = new System.Drawing.Size(370, 57);
            this.TextBox_CantidadMateriales.TabIndex = 3;
            this.TextBox_CantidadMateriales.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBox_PrecioCompraMaterial
            // 
            this.TextBox_PrecioCompraMaterial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_PrecioCompraMaterial.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_PrecioCompraMaterial.ForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_PrecioCompraMaterial.HintForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_PrecioCompraMaterial.HintText = "Precio compra";
            this.TextBox_PrecioCompraMaterial.isPassword = false;
            this.TextBox_PrecioCompraMaterial.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.TextBox_PrecioCompraMaterial.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextBox_PrecioCompraMaterial.LineMouseHoverColor = System.Drawing.Color.DarkCyan;
            this.TextBox_PrecioCompraMaterial.LineThickness = 3;
            this.TextBox_PrecioCompraMaterial.Location = new System.Drawing.Point(16, 105);
            this.TextBox_PrecioCompraMaterial.Margin = new System.Windows.Forms.Padding(6);
            this.TextBox_PrecioCompraMaterial.Name = "TextBox_PrecioCompraMaterial";
            this.TextBox_PrecioCompraMaterial.Size = new System.Drawing.Size(370, 55);
            this.TextBox_PrecioCompraMaterial.TabIndex = 2;
            this.TextBox_PrecioCompraMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TextBox_IdMaterial);
            this.panel1.Controls.Add(this.TextBox_NombreMaterial);
            this.panel1.Controls.Add(this.TextBox_DescripcionMaterial);
            this.panel1.Location = new System.Drawing.Point(10, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 282);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // TextBox_IdMaterial
            // 
            this.TextBox_IdMaterial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_IdMaterial.Enabled = false;
            this.TextBox_IdMaterial.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_IdMaterial.ForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_IdMaterial.HintForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_IdMaterial.HintText = "id";
            this.TextBox_IdMaterial.isPassword = false;
            this.TextBox_IdMaterial.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.TextBox_IdMaterial.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextBox_IdMaterial.LineMouseHoverColor = System.Drawing.Color.DarkCyan;
            this.TextBox_IdMaterial.LineThickness = 3;
            this.TextBox_IdMaterial.Location = new System.Drawing.Point(38, 25);
            this.TextBox_IdMaterial.Margin = new System.Windows.Forms.Padding(6);
            this.TextBox_IdMaterial.Name = "TextBox_IdMaterial";
            this.TextBox_IdMaterial.Size = new System.Drawing.Size(380, 57);
            this.TextBox_IdMaterial.TabIndex = 3;
            this.TextBox_IdMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBox_NombreMaterial
            // 
            this.TextBox_NombreMaterial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_NombreMaterial.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_NombreMaterial.ForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_NombreMaterial.HintForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_NombreMaterial.HintText = "Nombre del material";
            this.TextBox_NombreMaterial.isPassword = false;
            this.TextBox_NombreMaterial.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.TextBox_NombreMaterial.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextBox_NombreMaterial.LineMouseHoverColor = System.Drawing.Color.DarkCyan;
            this.TextBox_NombreMaterial.LineThickness = 3;
            this.TextBox_NombreMaterial.Location = new System.Drawing.Point(38, 105);
            this.TextBox_NombreMaterial.Margin = new System.Windows.Forms.Padding(6);
            this.TextBox_NombreMaterial.Name = "TextBox_NombreMaterial";
            this.TextBox_NombreMaterial.Size = new System.Drawing.Size(380, 55);
            this.TextBox_NombreMaterial.TabIndex = 1;
            this.TextBox_NombreMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBox_DescripcionMaterial
            // 
            this.TextBox_DescripcionMaterial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_DescripcionMaterial.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_DescripcionMaterial.ForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_DescripcionMaterial.HintForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_DescripcionMaterial.HintText = "Descripción";
            this.TextBox_DescripcionMaterial.isPassword = false;
            this.TextBox_DescripcionMaterial.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.TextBox_DescripcionMaterial.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextBox_DescripcionMaterial.LineMouseHoverColor = System.Drawing.Color.DarkCyan;
            this.TextBox_DescripcionMaterial.LineThickness = 3;
            this.TextBox_DescripcionMaterial.Location = new System.Drawing.Point(38, 195);
            this.TextBox_DescripcionMaterial.Margin = new System.Windows.Forms.Padding(6);
            this.TextBox_DescripcionMaterial.Name = "TextBox_DescripcionMaterial";
            this.TextBox_DescripcionMaterial.Size = new System.Drawing.Size(380, 55);
            this.TextBox_DescripcionMaterial.TabIndex = 1;
            this.TextBox_DescripcionMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Catalogo de materiales";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Tomato;
            this.bunifuCards2.Controls.Add(this.tabControl1);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(12, 455);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(1340, 520);
            this.bunifuCards2.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1344, 472);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvMaterialesAct);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1336, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Materiales Activos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvMaterialesAct
            // 
            this.dgvMaterialesAct.AllowUserToAddRows = false;
            this.dgvMaterialesAct.AllowUserToDeleteRows = false;
            this.dgvMaterialesAct.AllowUserToOrderColumns = true;
            this.dgvMaterialesAct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMaterialesAct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMaterialesAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialesAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterialesAct.Location = new System.Drawing.Point(3, 3);
            this.dgvMaterialesAct.Name = "dgvMaterialesAct";
            this.dgvMaterialesAct.ReadOnly = true;
            this.dgvMaterialesAct.RowHeadersWidth = 62;
            this.dgvMaterialesAct.RowTemplate.Height = 28;
            this.dgvMaterialesAct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterialesAct.Size = new System.Drawing.Size(1330, 433);
            this.dgvMaterialesAct.TabIndex = 0;
            this.dgvMaterialesAct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMaterialesAct_CellClick);
            this.dgvMaterialesAct.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMaterialesAct_CellContentDoubleClick);
            this.dgvMaterialesAct.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvMaterialesAct_CellMouseClick);
            this.dgvMaterialesAct.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvMaterialesAct_CellMouseDown);
            this.dgvMaterialesAct.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvMaterialesAct_CellMouseUp);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvMaterialesInac);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1336, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Materiales Inactivos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvMaterialesInac
            // 
            this.dgvMaterialesInac.AllowUserToAddRows = false;
            this.dgvMaterialesInac.AllowUserToDeleteRows = false;
            this.dgvMaterialesInac.AllowUserToOrderColumns = true;
            this.dgvMaterialesInac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialesInac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterialesInac.Location = new System.Drawing.Point(3, 3);
            this.dgvMaterialesInac.Name = "dgvMaterialesInac";
            this.dgvMaterialesInac.ReadOnly = true;
            this.dgvMaterialesInac.RowHeadersWidth = 62;
            this.dgvMaterialesInac.RowTemplate.Height = 28;
            this.dgvMaterialesInac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterialesInac.Size = new System.Drawing.Size(1330, 433);
            this.dgvMaterialesInac.TabIndex = 0;
            this.dgvMaterialesInac.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvMaterialesInac_CellMouseClick);
            this.dgvMaterialesInac.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvMaterialesInac_CellMouseDown);
            this.dgvMaterialesInac.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMaterialesInac_CellMouseEnter);
            this.dgvMaterialesInac.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvMaterialesInac_CellMouseUp);
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.DarkGray;
            this.bunifuCards3.Controls.Add(this.bunifuFlatButton2);
            this.bunifuCards3.Controls.Add(this.bunifuFlatButton3);
            this.bunifuCards3.Controls.Add(this.bunifuFlatButton1);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(12, 981);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(1340, 99);
            this.bunifuCards3.TabIndex = 12;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "ACTIVAR";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(905, 18);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(312, 62);
            this.bunifuFlatButton2.TabIndex = 4;
            this.bunifuFlatButton2.Text = "ACTIVAR";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Tomato;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "ELIMINAR";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(334, 18);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Tomato;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(312, 62);
            this.bunifuFlatButton3.TabIndex = 3;
            this.bunifuFlatButton3.Text = "ELIMINAR";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.BunifuFlatButton3_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "GUARDAR";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(10, 18);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(312, 62);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "GUARDAR";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // FormMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 1050);
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "FormMateriales";
            this.Text = "FormMateriales";
            this.Load += new System.EventHandler(this.FormMateriales_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesAct)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesInac)).EndInit();
            this.bunifuCards3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_CantidadMateriales;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_PrecioCompraMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_IdMaterial;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_NombreMaterial;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_DescripcionMaterial;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.ComboBox comboBox_NombreProvedor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvMaterialesAct;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvMaterialesInac;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_Buscar;
    }
}
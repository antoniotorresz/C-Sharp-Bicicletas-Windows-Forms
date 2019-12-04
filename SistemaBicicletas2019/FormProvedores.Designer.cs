namespace SistemaBicicletas2019
{
    partial class FormProvedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProvedores));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.TextBox_Buscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBox_TelefonoProvedor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_CorreoProvedor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox_IdProvedor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_NombreProvedor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_DireccionProvedor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.dataGridViewProvedores = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.lbltotal = new System.Windows.Forms.Label();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvedores)).BeginInit();
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
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.panel1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(12, 12);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1260, 474);
            this.bunifuCards1.TabIndex = 3;
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
            this.TextBox_Buscar.Location = new System.Drawing.Point(10, 394);
            this.TextBox_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Buscar.Name = "TextBox_Buscar";
            this.TextBox_Buscar.Size = new System.Drawing.Size(1033, 58);
            this.TextBox_Buscar.TabIndex = 16;
            this.TextBox_Buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_Buscar.OnValueChanged += new System.EventHandler(this.TextBox_Buscar_OnValueChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.TextBox_TelefonoProvedor);
            this.panel2.Controls.Add(this.TextBox_CorreoProvedor);
            this.panel2.Location = new System.Drawing.Point(454, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 282);
            this.panel2.TabIndex = 5;
            // 
            // TextBox_TelefonoProvedor
            // 
            this.TextBox_TelefonoProvedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_TelefonoProvedor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_TelefonoProvedor.ForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_TelefonoProvedor.HintForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_TelefonoProvedor.HintText = "Teléfono";
            this.TextBox_TelefonoProvedor.isPassword = false;
            this.TextBox_TelefonoProvedor.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.TextBox_TelefonoProvedor.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextBox_TelefonoProvedor.LineMouseHoverColor = System.Drawing.Color.DarkCyan;
            this.TextBox_TelefonoProvedor.LineThickness = 3;
            this.TextBox_TelefonoProvedor.Location = new System.Drawing.Point(16, 25);
            this.TextBox_TelefonoProvedor.Margin = new System.Windows.Forms.Padding(6);
            this.TextBox_TelefonoProvedor.Name = "TextBox_TelefonoProvedor";
            this.TextBox_TelefonoProvedor.Size = new System.Drawing.Size(370, 57);
            this.TextBox_TelefonoProvedor.TabIndex = 3;
            this.TextBox_TelefonoProvedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBox_CorreoProvedor
            // 
            this.TextBox_CorreoProvedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_CorreoProvedor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_CorreoProvedor.ForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_CorreoProvedor.HintForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_CorreoProvedor.HintText = "Correo electrónico";
            this.TextBox_CorreoProvedor.isPassword = false;
            this.TextBox_CorreoProvedor.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.TextBox_CorreoProvedor.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextBox_CorreoProvedor.LineMouseHoverColor = System.Drawing.Color.DarkCyan;
            this.TextBox_CorreoProvedor.LineThickness = 3;
            this.TextBox_CorreoProvedor.Location = new System.Drawing.Point(16, 105);
            this.TextBox_CorreoProvedor.Margin = new System.Windows.Forms.Padding(6);
            this.TextBox_CorreoProvedor.Name = "TextBox_CorreoProvedor";
            this.TextBox_CorreoProvedor.Size = new System.Drawing.Size(370, 55);
            this.TextBox_CorreoProvedor.TabIndex = 2;
            this.TextBox_CorreoProvedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(4, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Catalogo de provedores";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TextBox_IdProvedor);
            this.panel1.Controls.Add(this.TextBox_NombreProvedor);
            this.panel1.Controls.Add(this.TextBox_DireccionProvedor);
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 282);
            this.panel1.TabIndex = 4;
            // 
            // TextBox_IdProvedor
            // 
            this.TextBox_IdProvedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_IdProvedor.Enabled = false;
            this.TextBox_IdProvedor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_IdProvedor.ForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_IdProvedor.HintForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_IdProvedor.HintText = "id";
            this.TextBox_IdProvedor.isPassword = false;
            this.TextBox_IdProvedor.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.TextBox_IdProvedor.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextBox_IdProvedor.LineMouseHoverColor = System.Drawing.Color.DarkCyan;
            this.TextBox_IdProvedor.LineThickness = 3;
            this.TextBox_IdProvedor.Location = new System.Drawing.Point(38, 25);
            this.TextBox_IdProvedor.Margin = new System.Windows.Forms.Padding(6);
            this.TextBox_IdProvedor.Name = "TextBox_IdProvedor";
            this.TextBox_IdProvedor.Size = new System.Drawing.Size(380, 57);
            this.TextBox_IdProvedor.TabIndex = 3;
            this.TextBox_IdProvedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBox_NombreProvedor
            // 
            this.TextBox_NombreProvedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_NombreProvedor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_NombreProvedor.ForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_NombreProvedor.HintForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_NombreProvedor.HintText = "Nombre del provedor";
            this.TextBox_NombreProvedor.isPassword = false;
            this.TextBox_NombreProvedor.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.TextBox_NombreProvedor.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextBox_NombreProvedor.LineMouseHoverColor = System.Drawing.Color.DarkCyan;
            this.TextBox_NombreProvedor.LineThickness = 3;
            this.TextBox_NombreProvedor.Location = new System.Drawing.Point(38, 105);
            this.TextBox_NombreProvedor.Margin = new System.Windows.Forms.Padding(6);
            this.TextBox_NombreProvedor.Name = "TextBox_NombreProvedor";
            this.TextBox_NombreProvedor.Size = new System.Drawing.Size(380, 55);
            this.TextBox_NombreProvedor.TabIndex = 1;
            this.TextBox_NombreProvedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBox_DireccionProvedor
            // 
            this.TextBox_DireccionProvedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_DireccionProvedor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_DireccionProvedor.ForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_DireccionProvedor.HintForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_DireccionProvedor.HintText = "Direccion";
            this.TextBox_DireccionProvedor.isPassword = false;
            this.TextBox_DireccionProvedor.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.TextBox_DireccionProvedor.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextBox_DireccionProvedor.LineMouseHoverColor = System.Drawing.Color.DarkCyan;
            this.TextBox_DireccionProvedor.LineThickness = 3;
            this.TextBox_DireccionProvedor.Location = new System.Drawing.Point(38, 195);
            this.TextBox_DireccionProvedor.Margin = new System.Windows.Forms.Padding(6);
            this.TextBox_DireccionProvedor.Name = "TextBox_DireccionProvedor";
            this.TextBox_DireccionProvedor.Size = new System.Drawing.Size(380, 55);
            this.TextBox_DireccionProvedor.TabIndex = 1;
            this.TextBox_DireccionProvedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Tomato;
            this.bunifuCards2.Controls.Add(this.dataGridViewProvedores);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(9, 492);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(1263, 451);
            this.bunifuCards2.TabIndex = 10;
            // 
            // dataGridViewProvedores
            // 
            this.dataGridViewProvedores.AllowUserToAddRows = false;
            this.dataGridViewProvedores.AllowUserToDeleteRows = false;
            this.dataGridViewProvedores.AllowUserToOrderColumns = true;
            this.dataGridViewProvedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProvedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dataGridViewProvedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProvedores.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProvedores.Name = "dataGridViewProvedores";
            this.dataGridViewProvedores.ReadOnly = true;
            this.dataGridViewProvedores.RowHeadersWidth = 62;
            this.dataGridViewProvedores.RowTemplate.Height = 28;
            this.dataGridViewProvedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProvedores.Size = new System.Drawing.Size(1263, 451);
            this.dataGridViewProvedores.TabIndex = 1;
            this.dataGridViewProvedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewProvedores_CellContentClick_1);
            this.dataGridViewProvedores.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewProvedores_CellMouseClick);
            this.dataGridViewProvedores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridViewProvedores_KeyDown);
            this.dataGridViewProvedores.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DataGridViewProvedores_KeyUp);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 8;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 150;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.DarkGray;
            this.bunifuCards3.Controls.Add(this.lbltotal);
            this.bunifuCards3.Controls.Add(this.bunifuFlatButton3);
            this.bunifuCards3.Controls.Add(this.bunifuFlatButton1);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(9, 949);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(1263, 89);
            this.bunifuCards3.TabIndex = 11;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(882, 40);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(40, 20);
            this.lbltotal.TabIndex = 4;
            this.lbltotal.Text = "total";
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
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click_1);
            // 
            // FormProvedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 1050);
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "FormProvedores";
            this.Text = "FormProvedores";
            this.Load += new System.EventHandler(this.FormProvedores_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvedores)).EndInit();
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_TelefonoProvedor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_CorreoProvedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_IdProvedor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_NombreProvedor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_DireccionProvedor;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.DataGridView dataGridViewProvedores;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private System.Windows.Forms.Label lbltotal;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_Buscar;
    }
}
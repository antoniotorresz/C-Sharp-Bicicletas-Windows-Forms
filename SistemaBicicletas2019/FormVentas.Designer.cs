namespace Design_Dashboard_Modern
{
    partial class FormVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentas));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.Total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Textbox_Cantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Textbox_PrecioVenta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_NombreProducto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Textbox_Id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCards5 = new Bunifu.Framework.UI.BunifuCards();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnNuevaVenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.bunifuCards5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkCyan;
            this.bunifuCards1.Controls.Add(this.bunifuCards3);
            this.bunifuCards1.Controls.Add(this.bunifuCards2);
            this.bunifuCards1.Controls.Add(this.bunifuFlatButton2);
            this.bunifuCards1.Controls.Add(this.bunifuFlatButton4);
            this.bunifuCards1.Controls.Add(this.bunifuFlatButton1);
            this.bunifuCards1.Controls.Add(this.bunifuFlatButton3);
            this.bunifuCards1.Controls.Add(this.panel1);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 237);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1263, 808);
            this.bunifuCards1.TabIndex = 11;
            this.bunifuCards1.Visible = false;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.BunifuCards1_Paint);
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.Red;
            this.bunifuCards3.Controls.Add(this.Total);
            this.bunifuCards3.Controls.Add(this.label2);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(850, 569);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(380, 88);
            this.bunifuCards3.TabIndex = 13;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(164, 29);
            this.Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(58, 33);
            this.Total.TabIndex = 2;
            this.Total.Text = "0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "TOTAL:";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Teal;
            this.bunifuCards2.Controls.Add(this.dataGridView1);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(3, 234);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(1230, 329);
            this.bunifuCards2.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1230, 329);
            this.dataGridView1.TabIndex = 1;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Teal;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "   ADD PRODUCTO ";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(603, 54);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(252, 54);
            this.bunifuFlatButton2.TabIndex = 2;
            this.bunifuFlatButton2.Text = "   ADD PRODUCTO ";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Red;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "CANCELAR VENTA";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::SistemaBicicletas2019.Properties.Resources.trash_can_outline;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 60D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(887, 126);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Red;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(237, 54);
            this.bunifuFlatButton4.TabIndex = 11;
            this.bunifuFlatButton4.Text = "CANCELAR VENTA";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "   AGREGAR";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(603, 126);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(252, 54);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "   AGREGAR";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click_1);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "   REGISTRAR VENTA";
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
            this.bunifuFlatButton3.Location = new System.Drawing.Point(887, 54);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(237, 54);
            this.bunifuFlatButton3.TabIndex = 3;
            this.bunifuFlatButton3.Text = "   REGISTRAR VENTA";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.BunifuFlatButton3_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Textbox_Cantidad);
            this.panel1.Controls.Add(this.Textbox_PrecioVenta);
            this.panel1.Controls.Add(this.TextBox_NombreProducto);
            this.panel1.Controls.Add(this.Textbox_Id);
            this.panel1.Location = new System.Drawing.Point(16, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 211);
            this.panel1.TabIndex = 4;
            // 
            // Textbox_Cantidad
            // 
            this.Textbox_Cantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_Cantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_Cantidad.ForeColor = System.Drawing.Color.DarkCyan;
            this.Textbox_Cantidad.HintForeColor = System.Drawing.Color.DarkCyan;
            this.Textbox_Cantidad.HintText = "Cantidad";
            this.Textbox_Cantidad.isPassword = false;
            this.Textbox_Cantidad.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.Textbox_Cantidad.LineIdleColor = System.Drawing.Color.DimGray;
            this.Textbox_Cantidad.LineMouseHoverColor = System.Drawing.Color.DarkCyan;
            this.Textbox_Cantidad.LineThickness = 3;
            this.Textbox_Cantidad.Location = new System.Drawing.Point(208, 120);
            this.Textbox_Cantidad.Margin = new System.Windows.Forms.Padding(6);
            this.Textbox_Cantidad.Name = "Textbox_Cantidad";
            this.Textbox_Cantidad.Size = new System.Drawing.Size(243, 55);
            this.Textbox_Cantidad.TabIndex = 8;
            this.Textbox_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Textbox_PrecioVenta
            // 
            this.Textbox_PrecioVenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_PrecioVenta.Enabled = false;
            this.Textbox_PrecioVenta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_PrecioVenta.ForeColor = System.Drawing.Color.DarkCyan;
            this.Textbox_PrecioVenta.HintForeColor = System.Drawing.Color.DarkCyan;
            this.Textbox_PrecioVenta.HintText = "Precio venta";
            this.Textbox_PrecioVenta.isPassword = false;
            this.Textbox_PrecioVenta.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.Textbox_PrecioVenta.LineIdleColor = System.Drawing.Color.DimGray;
            this.Textbox_PrecioVenta.LineMouseHoverColor = System.Drawing.Color.DarkCyan;
            this.Textbox_PrecioVenta.LineThickness = 3;
            this.Textbox_PrecioVenta.Location = new System.Drawing.Point(16, 120);
            this.Textbox_PrecioVenta.Margin = new System.Windows.Forms.Padding(6);
            this.Textbox_PrecioVenta.Name = "Textbox_PrecioVenta";
            this.Textbox_PrecioVenta.Size = new System.Drawing.Size(162, 55);
            this.Textbox_PrecioVenta.TabIndex = 6;
            this.Textbox_PrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBox_NombreProducto
            // 
            this.TextBox_NombreProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_NombreProducto.Enabled = false;
            this.TextBox_NombreProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_NombreProducto.ForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_NombreProducto.HintForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_NombreProducto.HintText = "Nombre del producto";
            this.TextBox_NombreProducto.isPassword = false;
            this.TextBox_NombreProducto.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.TextBox_NombreProducto.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextBox_NombreProducto.LineMouseHoverColor = System.Drawing.Color.DarkCyan;
            this.TextBox_NombreProducto.LineThickness = 3;
            this.TextBox_NombreProducto.Location = new System.Drawing.Point(208, 14);
            this.TextBox_NombreProducto.Margin = new System.Windows.Forms.Padding(6);
            this.TextBox_NombreProducto.Name = "TextBox_NombreProducto";
            this.TextBox_NombreProducto.Size = new System.Drawing.Size(243, 55);
            this.TextBox_NombreProducto.TabIndex = 5;
            this.TextBox_NombreProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Textbox_Id
            // 
            this.Textbox_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_Id.Enabled = false;
            this.Textbox_Id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_Id.ForeColor = System.Drawing.Color.DarkCyan;
            this.Textbox_Id.HintForeColor = System.Drawing.Color.DarkCyan;
            this.Textbox_Id.HintText = "id";
            this.Textbox_Id.isPassword = false;
            this.Textbox_Id.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.Textbox_Id.LineIdleColor = System.Drawing.Color.DimGray;
            this.Textbox_Id.LineMouseHoverColor = System.Drawing.Color.DarkCyan;
            this.Textbox_Id.LineThickness = 3;
            this.Textbox_Id.Location = new System.Drawing.Point(16, 11);
            this.Textbox_Id.Margin = new System.Windows.Forms.Padding(6);
            this.Textbox_Id.Name = "Textbox_Id";
            this.Textbox_Id.Size = new System.Drawing.Size(162, 57);
            this.Textbox_Id.TabIndex = 4;
            this.Textbox_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCards5
            // 
            this.bunifuCards5.BackColor = System.Drawing.Color.White;
            this.bunifuCards5.BorderRadius = 5;
            this.bunifuCards5.BottomSahddow = true;
            this.bunifuCards5.color = System.Drawing.Color.Teal;
            this.bunifuCards5.Controls.Add(this.comboBox1);
            this.bunifuCards5.Controls.Add(this.btnNuevaVenta);
            this.bunifuCards5.Controls.Add(this.label10);
            this.bunifuCards5.Controls.Add(this.label9);
            this.bunifuCards5.Controls.Add(this.label7);
            this.bunifuCards5.Controls.Add(this.textBox1);
            this.bunifuCards5.Controls.Add(this.label6);
            this.bunifuCards5.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards5.LeftSahddow = false;
            this.bunifuCards5.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards5.Name = "bunifuCards5";
            this.bunifuCards5.RightSahddow = true;
            this.bunifuCards5.ShadowDepth = 20;
            this.bunifuCards5.Size = new System.Drawing.Size(1263, 231);
            this.bunifuCards5.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNuevaVenta.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNuevaVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevaVenta.BorderRadius = 0;
            this.btnNuevaVenta.ButtonText = "      NUEVA VENTA";
            this.btnNuevaVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaVenta.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaVenta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevaVenta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevaVenta.Iconimage")));
            this.btnNuevaVenta.Iconimage_right = null;
            this.btnNuevaVenta.Iconimage_right_Selected = null;
            this.btnNuevaVenta.Iconimage_Selected = null;
            this.btnNuevaVenta.IconMarginLeft = 0;
            this.btnNuevaVenta.IconMarginRight = 0;
            this.btnNuevaVenta.IconRightVisible = true;
            this.btnNuevaVenta.IconRightZoom = 0D;
            this.btnNuevaVenta.IconVisible = true;
            this.btnNuevaVenta.IconZoom = 60D;
            this.btnNuevaVenta.IsTab = false;
            this.btnNuevaVenta.Location = new System.Drawing.Point(944, 66);
            this.btnNuevaVenta.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Normalcolor = System.Drawing.Color.SeaGreen;
            this.btnNuevaVenta.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.btnNuevaVenta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevaVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNuevaVenta.selected = false;
            this.btnNuevaVenta.Size = new System.Drawing.Size(248, 54);
            this.btnNuevaVenta.TabIndex = 8;
            this.btnNuevaVenta.Text = "      NUEVA VENTA";
            this.btnNuevaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaVenta.Textcolor = System.Drawing.Color.White;
            this.btnNuevaVenta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaVenta.Click += new System.EventHandler(this.BtnNuevaVenta_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(430, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(303, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "ID VENTA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Numero Empleado";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(32, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fecha:";
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 1045);
            this.Controls.Add(this.bunifuCards5);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.bunifuCards5.ResumeLayout(false);
            this.bunifuCards5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_Cantidad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_PrecioVenta;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_NombreProducto;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_Id;
        private Bunifu.Framework.UI.BunifuCards bunifuCards5;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevaVenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
    }
}
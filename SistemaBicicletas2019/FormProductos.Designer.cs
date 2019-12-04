namespace Design_Dashboard_Modern
{
    partial class FormProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.TextBox_Buscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxProducto = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblfile = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBox_CantidadProducto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_PrecioProducto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox_DescripcionProducto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_IdProducto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_NombreProducto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvProductoAct = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dvgProductoInact = new System.Windows.Forms.DataGridView();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bunifuCards1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducto)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoAct)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProductoInact)).BeginInit();
            this.bunifuCards3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkCyan;
            this.bunifuCards1.Controls.Add(this.TextBox_Buscar);
            this.bunifuCards1.Controls.Add(this.panel3);
            this.bunifuCards1.Controls.Add(this.panel2);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.panel1);
            resources.ApplyResources(this.bunifuCards1, "bunifuCards1");
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            // 
            // TextBox_Buscar
            // 
            this.TextBox_Buscar.BackColor = System.Drawing.Color.White;
            this.TextBox_Buscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.TextBox_Buscar, "TextBox_Buscar");
            this.TextBox_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_Buscar.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_Buscar.HintText = "Buscar por valor";
            this.TextBox_Buscar.isPassword = false;
            this.TextBox_Buscar.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextBox_Buscar.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_Buscar.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextBox_Buscar.LineThickness = 3;
            this.TextBox_Buscar.Name = "TextBox_Buscar";
            this.TextBox_Buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_Buscar.OnValueChanged += new System.EventHandler(this.TextBox_Buscar_OnValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBoxProducto);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // pictureBoxProducto
            // 
            resources.ApplyResources(this.pictureBoxProducto, "pictureBoxProducto");
            this.pictureBoxProducto.Image = global::SistemaBicicletas2019.Properties.Resources.bicycle;
            this.pictureBoxProducto.Name = "pictureBoxProducto";
            this.pictureBoxProducto.TabStop = false;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.lblfile);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.TextBox_CantidadProducto);
            this.panel2.Controls.Add(this.TextBox_PrecioProducto);
            this.panel2.Name = "panel2";
            // 
            // lblfile
            // 
            resources.ApplyResources(this.lblfile, "lblfile");
            this.lblfile.Name = "lblfile";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox_CantidadProducto
            // 
            this.TextBox_CantidadProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.TextBox_CantidadProducto, "TextBox_CantidadProducto");
            this.TextBox_CantidadProducto.ForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_CantidadProducto.HintForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_CantidadProducto.HintText = "Stock";
            this.TextBox_CantidadProducto.isPassword = false;
            this.TextBox_CantidadProducto.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.TextBox_CantidadProducto.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextBox_CantidadProducto.LineMouseHoverColor = System.Drawing.Color.DarkCyan;
            this.TextBox_CantidadProducto.LineThickness = 3;
            this.TextBox_CantidadProducto.Name = "TextBox_CantidadProducto";
            this.TextBox_CantidadProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_CantidadProducto.OnValueChanged += new System.EventHandler(this.BunifuMaterialTextbox1_OnValueChanged);
            // 
            // TextBox_PrecioProducto
            // 
            this.TextBox_PrecioProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.TextBox_PrecioProducto, "TextBox_PrecioProducto");
            this.TextBox_PrecioProducto.ForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_PrecioProducto.HintForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_PrecioProducto.HintText = "Precio";
            this.TextBox_PrecioProducto.isPassword = false;
            this.TextBox_PrecioProducto.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.TextBox_PrecioProducto.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextBox_PrecioProducto.LineMouseHoverColor = System.Drawing.Color.DarkCyan;
            this.TextBox_PrecioProducto.LineThickness = 3;
            this.TextBox_PrecioProducto.Name = "TextBox_PrecioProducto";
            this.TextBox_PrecioProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_PrecioProducto.OnValueChanged += new System.EventHandler(this.BunifuMaterialTextbox2_OnValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TextBox_DescripcionProducto);
            this.panel1.Controls.Add(this.TextBox_IdProducto);
            this.panel1.Controls.Add(this.TextBox_NombreProducto);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // TextBox_DescripcionProducto
            // 
            this.TextBox_DescripcionProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.TextBox_DescripcionProducto, "TextBox_DescripcionProducto");
            this.TextBox_DescripcionProducto.ForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_DescripcionProducto.HintForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_DescripcionProducto.HintText = "Descripcion";
            this.TextBox_DescripcionProducto.isPassword = false;
            this.TextBox_DescripcionProducto.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.TextBox_DescripcionProducto.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextBox_DescripcionProducto.LineMouseHoverColor = System.Drawing.Color.DarkCyan;
            this.TextBox_DescripcionProducto.LineThickness = 3;
            this.TextBox_DescripcionProducto.Name = "TextBox_DescripcionProducto";
            this.TextBox_DescripcionProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBox_IdProducto
            // 
            this.TextBox_IdProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.TextBox_IdProducto, "TextBox_IdProducto");
            this.TextBox_IdProducto.ForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_IdProducto.HintForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_IdProducto.HintText = "id";
            this.TextBox_IdProducto.isPassword = false;
            this.TextBox_IdProducto.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.TextBox_IdProducto.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextBox_IdProducto.LineMouseHoverColor = System.Drawing.Color.DarkCyan;
            this.TextBox_IdProducto.LineThickness = 3;
            this.TextBox_IdProducto.Name = "TextBox_IdProducto";
            this.TextBox_IdProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_IdProducto.OnValueChanged += new System.EventHandler(this.BunifuMaterialTextbox3_OnValueChanged);
            // 
            // TextBox_NombreProducto
            // 
            this.TextBox_NombreProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.TextBox_NombreProducto, "TextBox_NombreProducto");
            this.TextBox_NombreProducto.ForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_NombreProducto.HintForeColor = System.Drawing.Color.DarkCyan;
            this.TextBox_NombreProducto.HintText = "Nombre del producto";
            this.TextBox_NombreProducto.isPassword = false;
            this.TextBox_NombreProducto.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.TextBox_NombreProducto.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextBox_NombreProducto.LineMouseHoverColor = System.Drawing.Color.DarkCyan;
            this.TextBox_NombreProducto.LineThickness = 3;
            this.TextBox_NombreProducto.Name = "TextBox_NombreProducto";
            this.TextBox_NombreProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCards2
            // 
            resources.ApplyResources(this.bunifuCards2, "bunifuCards2");
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Teal;
            this.bunifuCards2.Controls.Add(this.tabControl1);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvProductoAct);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvProductoAct
            // 
            this.dgvProductoAct.AllowUserToAddRows = false;
            this.dgvProductoAct.AllowUserToDeleteRows = false;
            this.dgvProductoAct.AllowUserToOrderColumns = true;
            this.dgvProductoAct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductoAct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductoAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvProductoAct, "dgvProductoAct");
            this.dgvProductoAct.Name = "dgvProductoAct";
            this.dgvProductoAct.ReadOnly = true;
            this.dgvProductoAct.RowTemplate.Height = 28;
            this.dgvProductoAct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductoAct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductoAct_CellContentClick);
            this.dgvProductoAct.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductoAct_CellContentDoubleClick);
            this.dgvProductoAct.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvProductoAct_CellMouseClick);
            this.dgvProductoAct.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvProductoAct_CellMouseDown);
            this.dgvProductoAct.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvProductoAct_CellMouseUp);
            this.dgvProductoAct.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DgvProductoAct_MouseDown);
            this.dgvProductoAct.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DgvProductoAct_MouseUp);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dvgProductoInact);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dvgProductoInact
            // 
            this.dvgProductoInact.AllowUserToAddRows = false;
            this.dvgProductoInact.AllowUserToDeleteRows = false;
            this.dvgProductoInact.AllowUserToOrderColumns = true;
            this.dvgProductoInact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dvgProductoInact, "dvgProductoInact");
            this.dvgProductoInact.Name = "dvgProductoInact";
            this.dvgProductoInact.ReadOnly = true;
            this.dvgProductoInact.RowTemplate.Height = 28;
            this.dvgProductoInact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgProductoInact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DvgProductoInact_CellContentClick);
            this.dvgProductoInact.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DvgProductoInact_CellMouseClick);
            this.dvgProductoInact.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DvgProductoInact_CellMouseDown);
            this.dvgProductoInact.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DvgProductoInact_MouseDown);
            this.dvgProductoInact.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DvgProductoInact_MouseUp);
            // 
            // bunifuCards3
            // 
            resources.ApplyResources(this.bunifuCards3, "bunifuCards3");
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.DarkGray;
            this.bunifuCards3.Controls.Add(this.button2);
            this.bunifuCards3.Controls.Add(this.bunifuFlatButton3);
            this.bunifuCards3.Controls.Add(this.bunifuFlatButton1);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Tomato;
            resources.ApplyResources(this.bunifuFlatButton3, "bunifuFlatButton3");
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
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Tomato;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.BunifuFlatButton3_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.bunifuFlatButton1, "bunifuFlatButton1");
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
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormProductos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ControlBox = false;
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.bunifuCards3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProductos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoAct)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProductoInact)).EndInit();
            this.bunifuCards3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_CantidadProducto;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_PrecioProducto;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_NombreProducto;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_IdProducto;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxProducto;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_DescripcionProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblfile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvProductoAct;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dvgProductoInact;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_Buscar;
    }
}
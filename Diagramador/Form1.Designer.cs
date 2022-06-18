namespace Diagramador
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarComoPNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoCuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoTrianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaFlechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loremToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loremToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loremToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.loremToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.loremToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.loremToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 420);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 30);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 420);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 420);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Image = global::Diagramador.Properties.Resources.circle_png;
            this.button2.Location = new System.Drawing.Point(3, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 78);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Image = global::Diagramador.Properties.Resources.line;
            this.button3.Location = new System.Drawing.Point(3, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 78);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Image = global::Diagramador.Properties.Resources.right_arrow;
            this.button4.Location = new System.Drawing.Point(3, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 78);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Image = global::Diagramador.Properties.Resources.rectangle1;
            this.button5.Location = new System.Drawing.Point(3, 339);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 78);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(774, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(26, 30);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.vistaToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.nuevoToolStripMenuItem,
            this.importarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + N";
            this.archivoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoCuadradoToolStripMenuItem,
            this.nuevoTrianguloToolStripMenuItem,
            this.nuevaFlechaToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // vistaToolStripMenuItem
            // 
            this.vistaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loremToolStripMenuItem,
            this.loremToolStripMenuItem1,
            this.loremToolStripMenuItem2});
            this.vistaToolStripMenuItem.Name = "vistaToolStripMenuItem";
            this.vistaToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.vistaToolStripMenuItem.Text = "Vista";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loremToolStripMenuItem3,
            this.loremToolStripMenuItem4,
            this.loremToolStripMenuItem5});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.guardarToolStripMenuItem.Text = "Nuevo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.nuevoToolStripMenuItem.Text = "Guardar";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirToolStripMenuItem,
            this.exportarComoPNGToolStripMenuItem});
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.importarToolStripMenuItem.Text = "Exportar";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // exportarComoPNGToolStripMenuItem
            // 
            this.exportarComoPNGToolStripMenuItem.Name = "exportarComoPNGToolStripMenuItem";
            this.exportarComoPNGToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.exportarComoPNGToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.exportarComoPNGToolStripMenuItem.Text = "PNG";
            this.exportarComoPNGToolStripMenuItem.Click += new System.EventHandler(this.exportarComoPNGToolStripMenuItem_Click);
            // 
            // nuevoCuadradoToolStripMenuItem
            // 
            this.nuevoCuadradoToolStripMenuItem.Name = "nuevoCuadradoToolStripMenuItem";
            this.nuevoCuadradoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nuevoCuadradoToolStripMenuItem.Text = "Nuevo cuadrado";
            // 
            // nuevoTrianguloToolStripMenuItem
            // 
            this.nuevoTrianguloToolStripMenuItem.Name = "nuevoTrianguloToolStripMenuItem";
            this.nuevoTrianguloToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nuevoTrianguloToolStripMenuItem.Text = "Nuevo circulo";
            this.nuevoTrianguloToolStripMenuItem.Click += new System.EventHandler(this.nuevoTrianguloToolStripMenuItem_Click);
            // 
            // nuevaFlechaToolStripMenuItem
            // 
            this.nuevaFlechaToolStripMenuItem.Name = "nuevaFlechaToolStripMenuItem";
            this.nuevaFlechaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nuevaFlechaToolStripMenuItem.Text = "Nueva flecha";
            // 
            // loremToolStripMenuItem
            // 
            this.loremToolStripMenuItem.Name = "loremToolStripMenuItem";
            this.loremToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loremToolStripMenuItem.Text = "lorem";
            // 
            // loremToolStripMenuItem1
            // 
            this.loremToolStripMenuItem1.Name = "loremToolStripMenuItem1";
            this.loremToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.loremToolStripMenuItem1.Text = "lorem";
            // 
            // loremToolStripMenuItem2
            // 
            this.loremToolStripMenuItem2.Name = "loremToolStripMenuItem2";
            this.loremToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.loremToolStripMenuItem2.Text = "lorem";
            // 
            // loremToolStripMenuItem3
            // 
            this.loremToolStripMenuItem3.Name = "loremToolStripMenuItem3";
            this.loremToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.loremToolStripMenuItem3.Text = "lorem";
            // 
            // loremToolStripMenuItem4
            // 
            this.loremToolStripMenuItem4.Name = "loremToolStripMenuItem4";
            this.loremToolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
            this.loremToolStripMenuItem4.Text = "lorem";
            // 
            // loremToolStripMenuItem5
            // 
            this.loremToolStripMenuItem5.Name = "loremToolStripMenuItem5";
            this.loremToolStripMenuItem5.Size = new System.Drawing.Size(224, 26);
            this.loremToolStripMenuItem5.Text = "lorem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem importarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem vistaToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem exportarComoPNGToolStripMenuItem;
        private ToolStripMenuItem nuevoCuadradoToolStripMenuItem;
        private ToolStripMenuItem nuevoTrianguloToolStripMenuItem;
        private ToolStripMenuItem nuevaFlechaToolStripMenuItem;
        private ToolStripMenuItem loremToolStripMenuItem;
        private ToolStripMenuItem loremToolStripMenuItem1;
        private ToolStripMenuItem loremToolStripMenuItem2;
        private ToolStripMenuItem loremToolStripMenuItem3;
        private ToolStripMenuItem loremToolStripMenuItem4;
        private ToolStripMenuItem loremToolStripMenuItem5;
    }
}
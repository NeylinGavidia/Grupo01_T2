using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo01_T2
{
    public partial class Form1 : Form
    {
        private List<Producto_G1> productos = new List<Producto_G1>();

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnOrdenAsc = new System.Windows.Forms.Button();
            this.btnOrdenDesc = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.G1_Cantidadstock = new System.Windows.Forms.PictureBox();
            this.G1_Costo = new System.Windows.Forms.PictureBox();
            this.G1_Clase = new System.Windows.Forms.PictureBox();
            this.G1_Producto = new System.Windows.Forms.PictureBox();
            this.G1_Verstock = new System.Windows.Forms.PictureBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.G1_Desc = new System.Windows.Forms.PictureBox();
            this.G1_Asc = new System.Windows.Forms.PictureBox();
            this.G1_Lupa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G1_Cantidadstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G1_Costo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G1_Clase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G1_Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G1_Verstock)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G1_Desc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G1_Asc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G1_Lupa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(65, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.Location = new System.Drawing.Point(159, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(315, 30);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.txtCategoria.Location = new System.Drawing.Point(159, 82);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(315, 30);
            this.txtCategoria.TabIndex = 3;
            this.txtCategoria.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(65, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoría:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrecio.Location = new System.Drawing.Point(159, 130);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(315, 30);
            this.txtPrecio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(65, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Control;
            this.txtCantidad.Location = new System.Drawing.Point(159, 175);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(315, 30);
            this.txtCantidad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(65, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(567, 40);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(228, 84);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(63, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "¿No encuentras lo que buscas?";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(410, 81);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(81, 30);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscar.Location = new System.Drawing.Point(66, 81);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(338, 30);
            this.txtBuscar.TabIndex = 11;
            // 
            // btnOrdenAsc
            // 
            this.btnOrdenAsc.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdenAsc.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnOrdenAsc.Location = new System.Drawing.Point(67, 165);
            this.btnOrdenAsc.Name = "btnOrdenAsc";
            this.btnOrdenAsc.Size = new System.Drawing.Size(104, 30);
            this.btnOrdenAsc.TabIndex = 12;
            this.btnOrdenAsc.Text = "Ascendente";
            this.btnOrdenAsc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenAsc.UseVisualStyleBackColor = false;
            this.btnOrdenAsc.Click += new System.EventHandler(this.btnOrdenAsc_Click);
            // 
            // btnOrdenDesc
            // 
            this.btnOrdenDesc.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdenDesc.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnOrdenDesc.Location = new System.Drawing.Point(177, 165);
            this.btnOrdenDesc.Name = "btnOrdenDesc";
            this.btnOrdenDesc.Size = new System.Drawing.Size(113, 30);
            this.btnOrdenDesc.TabIndex = 13;
            this.btnOrdenDesc.Text = "Descendente";
            this.btnOrdenDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenDesc.UseVisualStyleBackColor = false;
            this.btnOrdenDesc.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.Transparent;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStock.Location = new System.Drawing.Point(630, 175);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(94, 28);
            this.btnStock.TabIndex = 14;
            this.btnStock.Text = "Ver stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(63, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ordenar:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lstProductos
            // 
            this.lstProductos.BackColor = System.Drawing.SystemColors.Control;
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 23;
            this.lstProductos.Location = new System.Drawing.Point(67, 218);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(765, 165);
            this.lstProductos.TabIndex = 16;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(520, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(358, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "*Para revisar el stock escriba solo en la casilla de categoría";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.G1_Cantidadstock);
            this.groupBox1.Controls.Add(this.G1_Costo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.G1_Clase);
            this.groupBox1.Controls.Add(this.G1_Producto);
            this.groupBox1.Controls.Add(this.G1_Verstock);
            this.groupBox1.Controls.Add(this.btnStock);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCategoria);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 222);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // G1_Cantidadstock
            // 
            this.G1_Cantidadstock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.G1_Cantidadstock.BackColor = System.Drawing.Color.Transparent;
            this.G1_Cantidadstock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.G1_Cantidadstock.Image = ((System.Drawing.Image)(resources.GetObject("G1_Cantidadstock.Image")));
            this.G1_Cantidadstock.Location = new System.Drawing.Point(47, 179);
            this.G1_Cantidadstock.Name = "G1_Cantidadstock";
            this.G1_Cantidadstock.Size = new System.Drawing.Size(21, 18);
            this.G1_Cantidadstock.TabIndex = 22;
            this.G1_Cantidadstock.TabStop = false;
            // 
            // G1_Costo
            // 
            this.G1_Costo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.G1_Costo.BackColor = System.Drawing.Color.Transparent;
            this.G1_Costo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.G1_Costo.Image = ((System.Drawing.Image)(resources.GetObject("G1_Costo.Image")));
            this.G1_Costo.Location = new System.Drawing.Point(47, 131);
            this.G1_Costo.Name = "G1_Costo";
            this.G1_Costo.Size = new System.Drawing.Size(21, 18);
            this.G1_Costo.TabIndex = 21;
            this.G1_Costo.TabStop = false;
            // 
            // G1_Clase
            // 
            this.G1_Clase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.G1_Clase.BackColor = System.Drawing.Color.Transparent;
            this.G1_Clase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.G1_Clase.Image = ((System.Drawing.Image)(resources.GetObject("G1_Clase.Image")));
            this.G1_Clase.Location = new System.Drawing.Point(47, 85);
            this.G1_Clase.Name = "G1_Clase";
            this.G1_Clase.Size = new System.Drawing.Size(21, 18);
            this.G1_Clase.TabIndex = 20;
            this.G1_Clase.TabStop = false;
            // 
            // G1_Producto
            // 
            this.G1_Producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.G1_Producto.BackColor = System.Drawing.Color.Transparent;
            this.G1_Producto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.G1_Producto.Image = ((System.Drawing.Image)(resources.GetObject("G1_Producto.Image")));
            this.G1_Producto.Location = new System.Drawing.Point(47, 41);
            this.G1_Producto.Name = "G1_Producto";
            this.G1_Producto.Size = new System.Drawing.Size(21, 18);
            this.G1_Producto.TabIndex = 19;
            this.G1_Producto.TabStop = false;
            // 
            // G1_Verstock
            // 
            this.G1_Verstock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.G1_Verstock.BackColor = System.Drawing.Color.White;
            this.G1_Verstock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.G1_Verstock.Image = ((System.Drawing.Image)(resources.GetObject("G1_Verstock.Image")));
            this.G1_Verstock.Location = new System.Drawing.Point(702, 181);
            this.G1_Verstock.Name = "G1_Verstock";
            this.G1_Verstock.Size = new System.Drawing.Size(18, 18);
            this.G1_Verstock.TabIndex = 18;
            this.G1_Verstock.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnMostrarTodo);
            this.groupBox2.Controls.Add(this.G1_Desc);
            this.groupBox2.Controls.Add(this.G1_Asc);
            this.groupBox2.Controls.Add(this.G1_Lupa);
            this.groupBox2.Controls.Add(this.lstProductos);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnOrdenDesc);
            this.groupBox2.Controls.Add(this.btnOrdenAsc);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(21, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(895, 415);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INVENTARIO";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.BackColor = System.Drawing.Color.White;
            this.btnMostrarTodo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnMostrarTodo.Location = new System.Drawing.Point(702, 165);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(130, 30);
            this.btnMostrarTodo.TabIndex = 21;
            this.btnMostrarTodo.Text = "Mostrar todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = false;
            this.btnMostrarTodo.Click += new System.EventHandler(this.button1_Click);
            // 
            // G1_Desc
            // 
            this.G1_Desc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.G1_Desc.BackColor = System.Drawing.Color.White;
            this.G1_Desc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.G1_Desc.Image = ((System.Drawing.Image)(resources.GetObject("G1_Desc.Image")));
            this.G1_Desc.Location = new System.Drawing.Point(268, 172);
            this.G1_Desc.Name = "G1_Desc";
            this.G1_Desc.Size = new System.Drawing.Size(18, 18);
            this.G1_Desc.TabIndex = 20;
            this.G1_Desc.TabStop = false;
            // 
            // G1_Asc
            // 
            this.G1_Asc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.G1_Asc.BackColor = System.Drawing.Color.White;
            this.G1_Asc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.G1_Asc.Image = ((System.Drawing.Image)(resources.GetObject("G1_Asc.Image")));
            this.G1_Asc.Location = new System.Drawing.Point(148, 172);
            this.G1_Asc.Name = "G1_Asc";
            this.G1_Asc.Size = new System.Drawing.Size(18, 18);
            this.G1_Asc.TabIndex = 19;
            this.G1_Asc.TabStop = false;
            // 
            // G1_Lupa
            // 
            this.G1_Lupa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.G1_Lupa.BackColor = System.Drawing.Color.White;
            this.G1_Lupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.G1_Lupa.Image = ((System.Drawing.Image)(resources.GetObject("G1_Lupa.Image")));
            this.G1_Lupa.Location = new System.Drawing.Point(465, 88);
            this.G1_Lupa.Name = "G1_Lupa";
            this.G1_Lupa.Size = new System.Drawing.Size(21, 18);
            this.G1_Lupa.TabIndex = 17;
            this.G1_Lupa.TabStop = false;
            this.G1_Lupa.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 690);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Inventario de Tienda de Electrónicos (G1)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G1_Cantidadstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G1_Costo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G1_Clase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G1_Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G1_Verstock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G1_Desc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G1_Asc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G1_Lupa)).EndInit();
            this.ResumeLayout(false);

        }
        // este es el de registro
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                    string.IsNullOrWhiteSpace(txtCantidad.Text))
                {
                    throw new Exception("Todos los campos son obligatorios.");
                }

                string nombre = txtNombre.Text.Trim();
                string categoria = txtCategoria.Text.Trim();

                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                    throw new FormatException("El precio debe ser un número válido.");

                if (!int.TryParse(txtCantidad.Text, out int cantidad))
                    throw new FormatException("La cantidad debe ser un número válido.");

                // Verificar que no exista duplicado por nombre (insensible a mayúsculas)
                if (productos.Any(p => p.G1_Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)))
                    throw new Exception("El producto ya existe en el inventario.");

                productos.Add(new Producto_G1(nombre, categoria, precio, cantidad));

                ActualizarLista();
                LimpiarCampos();
                MessageBox.Show("Producto registrado correctamente.");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //actualizar lista
        private void ActualizarLista()
        {
            lstProductos.Items.Clear();
            foreach (var p in productos)
            {
                lstProductos.Items.Add(p.ToString());
            }
        }

        //limpiar campos del formulario

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCategoria.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtNombre.Focus();
        }

        //metodo para ordenar asc por burbuja
        private void OrdenarBurbujaAscendente()
        {
            for (int i = 0; i < productos.Count - 1; i++)
            {
                for (int j = 0; j < productos.Count - i - 1; j++)
                {
                    if (productos[j].G1_Precio > productos[j + 1].G1_Precio)
                    {
                        //auxiliar para el ordenamiento
                        var aux = productos[j];
                        productos[j] = productos[j + 1];
                        productos[j + 1] = aux;
                    }
                }
            }
        }

        //metodo para ordenar desc por burbuja
        private void OrdenarBurbujaDescendente()
        {
            for (int i = 0; i < productos.Count - 1; i++)
            {
                for (int j = 0; j < productos.Count - i - 1; j++)
                {
                    if (productos[j].G1_Precio < productos[j + 1].G1_Precio)
                    {
                        var aux = productos[j];
                        productos[j] = productos[j + 1];
                        productos[j + 1] = aux;
                    }
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //este es el de buscar
        private void button2_Click(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text.Trim().ToLower();
            var resultado = productos
                .Where(p => p.G1_Nombre.ToLower().Contains(buscar))
                .ToList();

            lstProductos.Items.Clear();
            foreach (var p in resultado)
                lstProductos.Items.Add(p.ToString());
        }

        //este es para mostrar todo
        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        //este es el de orden ascendente
        private void btnOrdenAsc_Click(object sender, EventArgs e)
        {
            OrdenarBurbujaAscendente();
            ActualizarLista();
            MessageBox.Show("Productos ordenados por precio (ascendente).");
        }

        //este el de orden descendente

        private void button4_Click(object sender, EventArgs e)
        {
            OrdenarBurbujaDescendente();
            ActualizarLista();
            MessageBox.Show("Productos ordenados por precio (descendente).");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //método para recursividad

        private int CalcularStockRecursivo(string categoria, int indice = 0, int total = 0)
        {
            // aqui revisamos la lsita
            if (indice == productos.Count)
            {
                return total;
            }


            // esto ayuda a comparar lo que esta en la lsita con lo que se ingresa
            string catLista = productos[indice].G1_Categoria.ToLower();
            string catBuscada = categoria.ToLower();

            if (catLista == catBuscada)
            {
                total = total + productos[indice].G1_Cantidad;
            }

            // aqui se aplic la recursividad llamandose asi misma
            return CalcularStockRecursivo( categoria, indice + 1, total);
        }

        //buscar por stock
        private void btnStock_Click(object sender, EventArgs e)
        {
            string categoria = txtCategoria.Text.Trim();
            if (string.IsNullOrWhiteSpace(categoria))
            {
                MessageBox.Show("Ingrese una categoría para calcular el stock.");
                return;
            }

            int total = CalcularStockRecursivo(categoria);
            MessageBox.Show("El stock total de productos de " + categoria + " es: " + total);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

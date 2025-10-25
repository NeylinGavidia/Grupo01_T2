using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Grupo01_T2
{
    public partial class Form1
    {
          
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtCategoria;
        private Label label2;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtCantidad;
        private Label label4;
        private Button btnRegistrar;
        private Label label5;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnOrdenAsc;
        private Button btnOrdenDesc;
        private Button btnStock;
        private Label label6;
        private ListBox lstProductos;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private Label label7;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private PictureBox G1_Lupa;
        private PictureBox G1_Verstock;
        private PictureBox G1_Desc;
        private PictureBox G1_Asc;
        private PictureBox G1_Cantidadstock;
        private PictureBox G1_Costo;
        private PictureBox G1_Clase;
        private PictureBox G1_Producto;
        private Button btnMostrarTodo;
    }
}


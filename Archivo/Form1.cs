using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            using(StreamWriter writer = new StreamWriter("archivo.txt"))
            {
                writer.Write(textBox1.Text);
            }
            MessageBox.Show("Guardado :·V ");
        }

        private void Leer_button_Click(object sender, EventArgs e)
        {
            using(StreamReader reader=new StreamReader("archivo.txt"))
            {
                label1.Text = reader.ReadLine();
            }
        }
    }
}

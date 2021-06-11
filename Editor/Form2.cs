using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class Reemplazar : Form
    {
        private string pbuscar;//declarar variables para los constructores
        private string preemplazar;


        public string Pbuscar //crear el contrictor para mandar mensaje
        {
            get { return pbuscar; }
        }
        
        public string Preemplazar
        {
            get { return preemplazar; }
        }

        public Reemplazar()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3Reemplazar_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            //enviar lo del textbox a las variables para el constructor
            pbuscar = textBoxPalabraBuscar.Text;
            preemplazar = textBoxPalabraReemplazar.Text;
            this.Close();//cierra e form pero no pierde la info
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

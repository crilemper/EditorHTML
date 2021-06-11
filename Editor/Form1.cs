using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace Editor
{
    public partial class Form1 : Form
    {
        string archivo;
        //////////Etiquetas
        string[] Reservadas = new string[] {"address","applet","area","<a>","base","basefont","big","button","blockquote",
                                "body","br","<b>","caption","center","cite","code","div","dl","form","font","html","head",
                                "<p>","form","h1","h2","h3","h4","h5","h6","head","img","hr","<i>","input","link","li","map",
                                "marquee","menu","meta","option","param","</p>","script","title","type","select","small","strong",
                                "style","table","th","tr","ul","<u>","var","values","name","placeholder"};
        /////////Atributos
        string[] Reservadas2 = new string[] {"bgcolor","size","color","face","selected","value","href","style","behavior",
                                "direction","width","heigth","hspace","scrollamount","scrolldelay","truespeed"};

        /////////Colores y Palabas varias
        string[] Reservadas3 = new string[] {"aqua","black","blue","fuchsia","gray","green","lime","maroon","navy","olive",
                                "purple","red","silver","teal","white","yellow","border",":","solid","left","rigth","up",
                                "down","truespeed","alternate"};

        /////////Simbolos
        string[] Reservadas4 = new string[] {"<",">","/"};
        
        //int posicion = 0;
        //importantes para buscar
        int t = 0;
        int nb_result = 0;


        public Form1()
        {
            InitializeComponent();
            {
                
                this.fastColoredTextBox1.TextChanged += (ob, ev) =>//PINTAR PALABRAS
                {
                    ///ejecucion();
                    //ejecucion2();
                   // ejecucion3();
                   // ejecucion4();
                };

            }
        }

        private void ejecucion()///PINTA ETIQUETAS
        {
           fastColoredTextBox1.SelectionStart=0;
           fastColoredTextBox1.SelectionStart =fastColoredTextBox1.TextLength;
           fastColoredTextBox1.SelectionColor =fastColoredTextBox1.ForeColor;
            

            foreach (string x in Reservadas)
            {
                int index = 0;
                while(index<=fastColoredTextBox1.Text.LastIndexOf(x)){
                  // fastColoredTextBox1.Find(x, index,fastColoredTextBox1.TextLength,RichTextBoxFinds.WholeWord);
                    fastColoredTextBox1.SelectionColor=Color.OrangeRed;
                    index=fastColoredTextBox1.Text.IndexOf(x,index)+1;
                }
               
            }
           fastColoredTextBox1.SelectionStart =fastColoredTextBox1.TextLength;
           fastColoredTextBox1.SelectionColor =fastColoredTextBox1.ForeColor;
           
        }

        private void ejecucion2()///PINTA ATRIBUTOS
        {
           fastColoredTextBox1.SelectionStart=0;
           fastColoredTextBox1.SelectionStart =fastColoredTextBox1.TextLength;
           fastColoredTextBox1.SelectionColor =fastColoredTextBox1.ForeColor;

            foreach (string x in Reservadas2)
            {
                int index = 0;
                while(index<=fastColoredTextBox1.Text.LastIndexOf(x)){
                  // fastColoredTextBox1.Find(x, index,fastColoredTextBox1.TextLength,RichTextBoxFinds.WholeWord);
                    fastColoredTextBox1.SelectionColor=Color.Lime;
                    index=fastColoredTextBox1.Text.IndexOf(x,index)+1;
                }
               
            }
           fastColoredTextBox1.SelectionStart =fastColoredTextBox1.TextLength;
           fastColoredTextBox1.SelectionColor =fastColoredTextBox1.ForeColor;
           
        }

        private void ejecucion3()///PINTA COLORES
        {
           fastColoredTextBox1.SelectionStart=0;
           fastColoredTextBox1.SelectionStart =fastColoredTextBox1.TextLength;
           fastColoredTextBox1.SelectionColor =fastColoredTextBox1.ForeColor;

            foreach (string x in Reservadas3)
            {
                int index = 0;
                while(index<=fastColoredTextBox1.Text.LastIndexOf(x)){
                  // fastColoredTextBox1.Find(x, index,fastColoredTextBox1.TextLength,RichTextBoxFinds.WholeWord);
                    fastColoredTextBox1.SelectionColor=Color.Yellow;
                    index=fastColoredTextBox1.Text.IndexOf(x,index)+1;
                }
               
            }
           fastColoredTextBox1.SelectionStart =fastColoredTextBox1.TextLength;
           fastColoredTextBox1.SelectionColor =fastColoredTextBox1.ForeColor;
           
        }

        private void ejecucion4()///PINTA <,> y /
        {
           fastColoredTextBox1.SelectionStart=0;
           fastColoredTextBox1.SelectionStart =fastColoredTextBox1.TextLength;
           fastColoredTextBox1.SelectionColor =fastColoredTextBox1.ForeColor;

            foreach (string x in Reservadas4)
            {
                int index = 0;
                while(index<=fastColoredTextBox1.Text.LastIndexOf(x)){
                   //fastColoredTextBox1.Find(x, index,fastColoredTextBox1.TextLength,RichTextBoxFinds.WholeWord);
                    fastColoredTextBox1.SelectionColor=Color.OrangeRed;
                    index=fastColoredTextBox1.Text.IndexOf(x,index)+1;
                }
               
            }
           fastColoredTextBox1.SelectionStart =fastColoredTextBox1.TextLength;
           fastColoredTextBox1.SelectionColor =fastColoredTextBox1.ForeColor;
           
        }



        private void aBRIRToolStripMenuItem_Click(object sender, EventArgs e)//BOTON ABRIR
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            Openfile.Filter = "Texto|*.HTML";
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                archivo = Openfile.FileName;
                using (StreamReader sr = new StreamReader(archivo))
                {
                   fastColoredTextBox1.Text = sr.ReadToEnd();
                }
                //Form1.ActiveForm.Text = FileName + "BANSAI-TEXT";
            }
        }

        private void gUARDARToolStripMenuItem_Click(object sender, EventArgs e)//BOTON GUARDAR
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Texto|*.HTML";
            if (archivo != null)
            {
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
            else
            {
                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    archivo = SaveFile.FileName;
                    using (StreamWriter sw = new StreamWriter(SaveFile.FileName))
                    {
                        sw.Write(fastColoredTextBox1.Text);
                    }
                }
            }
        }

        private void gUARDARCOMOToolStripMenuItem_Click(object sender, EventArgs e)//BOTON GUARDAR COMO
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Texto|*.HTML";
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                archivo = SaveFile.FileName;
                using (StreamWriter sw = new StreamWriter(SaveFile.FileName))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void nUEVOToolStripMenuItem_Click(object sender, EventArgs e)//NUEVO--FALTAN PESTAÑAS
        {
           fastColoredTextBox1.Clear();
            archivo = null;

        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)//SALIR XD
        {
            //this.Dispose();//CODIGO PARA SALIR XD HAY QUE CORRERLO A LA FUNCON CERRAR
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       /* public void AddLineNumbers()
        {
            // create & set Point pt to (0,0)    
            Point pt = new Point(0, 0);
            // get First Index & First Line fromfastColoredTextBox1    
            int First_Index =fastColoredTextBox1.GetCharIndexFromPosition(pt);
            int First_Line =fastColoredTextBox1.GetLineFromCharIndex(First_Index);
            // set X & Y coordinates of Point pt to ClientRectangle Width & Height respectively    
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            // get Last Index & Last Line fromfastColoredTextBox1    
            int Last_Index =fastColoredTextBox1.GetCharIndexFromPosition(pt);
            int Last_Line =fastColoredTextBox1.GetLineFromCharIndex(Last_Index);
            // set Center alignment to LineNumberTextBox    
            LineNumberTextBox.SelectionAlignment = HorizontalAlignment.Center;
            // set LineNumberTextBox text to null & width to getWidth() function value    
            LineNumberTextBox.Text = "";
            //LineNumberTextBox.Width = getWidth();
            // now add each line number to LineNumberTextBox upto last line    
            for (int i = First_Line; i <= Last_Line; i++)
            {
                LineNumberTextBox.Text += i + 1 + "\n";
            }
        }
        */

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(fastColoredTextBox1.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
        }

        private void iMPRIMIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void cOPIARToolStripMenuItem_Click(object sender, EventArgs e)//ATRAS
        {
           fastColoredTextBox1.Undo();
        }

        private void pEGARToolStripMenuItem_Click(object sender, EventArgs e)//ADELANTE
        {
           fastColoredTextBox1.Redo();
        }

        private void aTRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
           fastColoredTextBox1.Copy();
        }

        private void aDELANTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           fastColoredTextBox1.Cut();
        }

        private void pEGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           fastColoredTextBox1.Paste();
        }

        private void sELECIONARTODOToolStripMenuItem_Click(object sender, EventArgs e)
        {
           fastColoredTextBox1.SelectAll();
        }

        private void eLIMINARTODOToolStripMenuItem_Click(object sender, EventArgs e)
        {
           fastColoredTextBox1.Clear();
        }

        private void bANSAIXDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DOM();
            frm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?", "Cerrar Programa",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogo==DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        //private voidfastColoredTextBox1_TextChanged(object sender, EventArgs e)
        //{
        //    ///AddLineNumbers();
        //   // showLineNo();
        //}
        //FUNCION PARA MOSTRAR NUMERO DE LINEA
        private void showLineNo()
        {
            //// Obtiene la ubicación actual
            //Point p = this.fastColoredTextBox1.Location;
            //int crntFirstIndex = this.fastColoredTextBox1.GetCharIndexFromPosition(p);
            //int crntFirstLine = this.fastColoredTextBox1.GetLineFromCharIndex(crntFirstIndex);
            //Point crntFirstPos = this.fastColoredTextBox1.GetPositionFromCharIndex(crntFirstIndex);
            //p.Y += this.fastColoredTextBox1.Height;
            //int crntLastIndex = this.fastColoredTextBox1.GetCharIndexFromPosition(p);
            //int crntLastLine = this.fastColoredTextBox1.GetLineFromCharIndex(crntLastIndex);
            //Point crntLastPos = this.fastColoredTextBox1.GetPositionFromCharIndex(crntLastIndex);

            //// Conjunto de pincel
            //Graphics g = this.panel1.CreateGraphics();
            //Font font = new Font(this.fastColoredTextBox1.Font, this.fastColoredTextBox1.Font.Style);
            //SolidBrush brush = new SolidBrush(Color.Green);
            //Rectangle rect = this.panel1.ClientRectangle;
            //brush.Color = this.panel1.BackColor;
            //g.FillRectangle(brush, 0, 0, this.panel1.ClientRectangle.Width, this.panel1.ClientRectangle.Height);
            //brush.Color = Color.Black;

            //// Escribe el numero de línea
            //int lineSpace = 0;
            //if (crntFirstLine != crntLastLine)
            //{
            //    lineSpace = (crntLastPos.Y - crntFirstPos.Y) / (crntLastLine - crntFirstLine);
            //}
            //else
            //{
            //    lineSpace = Convert.ToInt32(this.fastColoredTextBox1.Font.Size);
            //}

            //int brushX = this.panel1.ClientRectangle.Width - Convert.ToInt32(font.Size * 3);
            //int brushY = crntLastPos.Y + Convert.ToInt32(font.Size * 0.21f);
            //for (int i = crntLastLine; i >= crntFirstLine; i--)
            //{
            //    g.DrawString((i + 1).ToString(), font, brush, brushX, brushY);
            //    brushY -= lineSpace;
            //}
            //g.Dispose();
            //font.Dispose();
            //brush.Dispose();
        }

        private void aCERCADEBANSAITEXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new AYUDA();
            frm1.Show();
        }

        private void LineNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Panel que que muestra el numero de linea
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aRCHIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bUSCARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void bUSCARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowFindDialog();
            /*
            //loop para buscar dentro del richtextbox
            for (int i = t ; i <=fastColoredTextBox1.TextLength-textbox_buscar.TextLength ; i++) 
            {
                
                string x = "";
                //Busca una palabra dentro de otra
                for (int j = 0 ; j < textbox_buscar.TextLength ; j++)
                {
                    if (textbox_buscar.Text[ j ] ==fastColoredTextBox1.Text[i + j]) 
                    {
                        
                        x +=fastColoredTextBox1.Text[i + j] + "";
                    }
                    else
                    {
                        x = "" ;
                    }
                
                }
                if (x == textbox_buscar.Text)
                {
                    t = i + 1;
                    //selecciona todo el texto
                   fastColoredTextBox1.SelectAll();
                    //colorea todo el texto del color del fondo
                   fastColoredTextBox1.Selection =fastColoredTextBox1.BackColor;
                    //selecciona el resultado
                   fastColoredTextBox1.Select(i,textbox_buscar.TextLength);
                    //colorea el resultado
                   fastColoredTextBox1.SelectionBackColor = Color.Orange;
                    nb_result++;
                    break;
                }
                if (i ==fastColoredTextBox1.TextLength - textbox_buscar.TextLength)
                { 
                    if(nb_result > 0)
                    {
                        MessageBox.Show("La busqueda se ha completado");
                       fastColoredTextBox1.SelectAll();
                       fastColoredTextBox1.SelectionBackColor =fastColoredTextBox1.BackColor;
                    }
                        
                      else
                    {
                        MessageBox.Show("No hay resultados");
                    }
                    t = 0;

                }

            }*/

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // //selecciona todo el texto
           //fastColoredTextBox1.SelectAll();
           // //colorea todo el texto del color del fondo
           //fastColoredTextBox1.SelectionBackColor =fastColoredTextBox1.BackColor;
           // nb_result = 0;
           // t = 0;
        }

        private void fUENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmto = fontDialog1.ShowDialog();
            if (frmto==DialogResult.OK)
            {
               fastColoredTextBox1.Font = fontDialog1.Font; 
            }
        }

        private void hORAYFECHAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            string hor = "";
            hor= hoy.ToShortTimeString()+" "+ hoy.ToShortDateString();
            MessageBox.Show(hor);
            // fastColoredTextBox1.Text += hoy.ToShortTimeString();
            //fastColoredTextBox1.Text += " ";
            //fastColoredTextBox1.Text += hoy.ToShortDateString();

        }

        private void rEEMPLAZARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowReplaceDialog();
            ////inicializar la forma para la busqueda de informacion
            //Reemplazar miforma2 = new Reemplazar();
            //// se manda la ejecucion la 2da forma
            //miforma2.ShowDialog();
            ////variables para la busqueda
            //string b = "";
            //string r = "";
            
            ////se guarda las palabras en las variables
            //b = miforma2.Pbuscar;
            //r = miforma2.Preemplazar;
            //int a = 0;
            //int a2 = 0;
            //if (b!="" && b!=null) 
            //{

            //     a = b.Length;
            //     a2 = r.Length;//tamaño de string
            //                      //loop para buscar dentro del richtextbox
            //    char[] arrayp = b.ToCharArray();//convierte string en array
            //    for (int i = t; i <=fastColoredTextBox1.TextLength - a; i++)
            //    {
            //        string x = "";
            //        //Busca una palabra dentro de otra
            //        for (int j = 0; j < a; j++)
            //        {
            //            if (arrayp[j] ==fastColoredTextBox1.Text[i + j])
            //            {

            //                x +=fastColoredTextBox1.Text[i + j] + "";
            //            }
            //            else
            //            {
            //                x = "";
            //            }
            //        }
            //        if (x == b && b != "" && r != "")//reemplazar la palabra
            //        {
            //            t = i + 1;
            //            string nuevorich =fastColoredTextBox1.Text;
            //            string nuevotexto = nuevorich.Replace(b, r);
            //            //funcion reemplazar
            //           fastColoredTextBox1.Text = nuevotexto;
            //           fastColoredTextBox1.Refresh();

            //            //selecciona todo el texto
            //           fastColoredTextBox1.SelectAll();
            //            //colorea todo el texto del color del fondo
            //          // fastColoredTextBox1.SelectionBackColor =fastColoredTextBox1.BackColor;
            //            //selecciona el resultado 
            //            //fastColoredTextBox1.Select(i, a2);
            //            //colorea el resultado
            //            //fastColoredTextBox1.SelectionBackColor = Color.Orange;
            //            nb_result++;
            //            break;
            //        }
            //        if (i ==fastColoredTextBox1.TextLength - a)
            //        {
            //            if (nb_result > 0)
            //            {
            //                MessageBox.Show("La busqueda se ha completado");
            //            }
            //            else
            //            {
            //                MessageBox.Show("No hay resultados");
            //            }
            //            t = 0;

            //        }

            //    }
            //}
            
        }

        private void sELECCIONARTODOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.SelectAll();
        }

        private void cORTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void pEGARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void pEGARToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void iRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void iRAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowGoToDialog();
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void aYUDAToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}

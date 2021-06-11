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
    public partial class web1 : Form
    {
        public web1(string file)
        {
            InitializeComponent();
            webBrowser1.DocumentText = file;
        }
    }
}

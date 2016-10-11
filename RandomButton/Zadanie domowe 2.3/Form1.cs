using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_domowe_2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var rnd = new Random();
            var x = rnd.Next();
            var y = rnd.Next();
            x = r.Next();
            y = y.Next();
            button1.Location = new Point(x, y);
           
        }
    }
}

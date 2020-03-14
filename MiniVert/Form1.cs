using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniVert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form2Razrab Razrab { get; set; } = new Form2Razrab();

        private void button1_Click(object sender, EventArgs e)
        {
            Razrab.ShowDialog();
        }
    }
}

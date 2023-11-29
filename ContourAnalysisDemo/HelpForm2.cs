using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContourAnalysisDemo
{
    public partial class HelpForm2 : Form
    {
        public HelpForm2()
        {
            InitializeComponent();
        }


        private void HelpForm2_Load(object sender, EventArgs e)
        {
            richTextBox2.LoadFile(".\\原理说明书.rtf");
        }

        private void btclose2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

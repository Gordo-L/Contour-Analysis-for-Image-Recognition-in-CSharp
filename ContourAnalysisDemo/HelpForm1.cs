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
    public partial class HelpForm1 : Form
    {
        public HelpForm1()
        {
            InitializeComponent();
        }

        private void HelpForm1_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(".\\使用说明书.rtf");
        }

        private void btclose1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            String Input = textBox_submit.Text.ToString();
            textBox_submit.ResetText();

            textBox_log.AppendText(Input + Environment.NewLine);
        }

        private void textBox_log_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String Input = "Load Successfully";

            textBox_log.AppendText(Input + Environment.NewLine);

            textBox_log.ReadOnly = true;
        }

        private void textBox_log_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Back)
                textBox_log.ResetText();
        }

        private void textBox_submit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.button_submit_Click(sender, e);
        }
    }
}

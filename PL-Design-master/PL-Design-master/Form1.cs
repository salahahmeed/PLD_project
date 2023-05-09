using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.calitha.commons;
using com.calitha.goldparser;

namespace PLD
{
    public partial class Form1 : Form
    {
        MyParser parser;
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            parser = new MyParser("Mygrammer.cgt", listBox1, dt);
            dgv.DataSource = dt;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            parser.Parse(richTextBox1.Text);
            dgv.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

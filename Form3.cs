using _06.ADO.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06
{
    public partial class Form3 : Form
    {

        public Model1 db { get; set; }

        public Kvartirs1 kvartirs1 { get; set; }

        

        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = kvartirs1.ID.ToString();
            textBox2.Text = kvartirs1.Vladelec;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kvartirs1.Vladelec = textBox2.Text;

            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }
    }
}

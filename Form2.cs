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
    public partial class Form2 : Form
    {
        public Model1 db { get; set; }


        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Нужно ввести все данные");
                return;
            }

            int id = 0;
            int raz = 0, vozrast = 0;


            bool b = int.TryParse(textBox1.Text, out id) ||
               int.TryParse(textBox3.Text, out raz) ||
               int.TryParse(textBox4.Text, out vozrast);

            if (b == false)
            {

                MessageBox.Show("Неверный формат ID" + textBox1);
                return;

            }

            Kvartirs1 kvartirs1 = new Kvartirs1();

            kvartirs1.ID = id;
            kvartirs1.Vladelec = textBox2.Text;
            kvartirs1.Размер = raz;
            kvartirs1.Vozrast = vozrast;


            db.Kvartirs1.Add(kvartirs1);
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch(Exception ex) { 
            
                MessageBox.Show(ex.InnerException.InnerException.Message);

            }
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

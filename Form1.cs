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
    public partial class Form1 : Form
    {

        Model1 db = new Model1();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kvartirsDataSet.Kvartirs1". При необходимости она может быть перемещена или удалена.
           //this.kvartirs1TableAdapter.Fill(this.kvartirsDataSet.Kvartirs1);
           kvartirs1BindingSource.DataSource = db.Kvartirs1.ToList();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.db = db;

            DialogResult dr = form2.ShowDialog();

            if (dr == DialogResult.OK)
            {
                kvartirs1BindingSource.DataSource = db.Kvartirs1.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();

            Kvartirs1 kvartirs1 = (Kvartirs1)kvartirs1BindingSource.Current;
            frm.db = db;
            frm.kvartirs1 = kvartirs1;

            DialogResult dr = frm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                kvartirs1BindingSource.DataSource = db.Kvartirs1.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kvartirs1 kvartirs1 = (Kvartirs1)kvartirs1BindingSource.Current;

            DialogResult dr = MessageBox.Show("ВЫ дествительно хотите удалить роль - " +
                kvartirs1.ID.ToString(), "Удаление роли", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                db.Kvartirs1.Remove(kvartirs1);

                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)  
                { 
                    MessageBox.Show(ex.Message);
                }
                kvartirs1BindingSource.DataSource = db.Kvartirs1.ToList();
            }
        }
    }
}

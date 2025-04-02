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
    }
}

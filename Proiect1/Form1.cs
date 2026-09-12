using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect1
{
    public partial class Proiect : Form
    {
        public Proiect()
        {
            InitializeComponent();
        }

        private void Proiect_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proiect_DateDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.proiect_DateDataSet.Table);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string denumire = txtName.Text;
            int pret = int.Parse(txtPret.Text);
            string data = dtp.Text;

            tableTableAdapter.InsertProdus(denumire, pret, data);
            this.tableTableAdapter.Fill(this.proiect_DateDataSet.Table);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int min = int.Parse(txtmin.Text);
            int max = int.Parse(txtmax.Text);
            tableTableAdapter.SelectBetween(this.proiect_DateDataSet.Table,min, max);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(txtDelete.Text);
            tableTableAdapter.DeleteProdus(cod);
            this.tableTableAdapter.Fill(this.proiect_DateDataSet.Table);
        }

        private void btnOrd_Click(object sender, EventArgs e)
        {
            int ord= int.Parse(txtOrd.Text);
          // string ord = txtOrd.Text;
            tableTableAdapter.Order(this.proiect_DateDataSet.Table, ord);
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            tableTableAdapter.OrdDesc(this.proiect_DateDataSet.Table);
        }
    }
}

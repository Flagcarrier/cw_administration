using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace cw_administration
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.clientBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.cw_adminDataSet);

        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cw_adminDataSet.orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.cw_adminDataSet.orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cw_adminDataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.cw_adminDataSet.clients);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "cw_adminDataSet.clients". При необходимости она может быть перемещена или удалена.
            //this.clientsTableAdapter.Fill(this.cw_adminDataSet.clients);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "cw_adminDataSet.client". При необходимости она может быть перемещена или удалена.
            ////this.clientTableAdapter.Fill(this.cw_adminDataSet.client);

        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cw_adminDataSet);

        }
    }
     

}
 

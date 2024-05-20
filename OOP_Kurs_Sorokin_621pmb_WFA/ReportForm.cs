using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void button_Users_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            this.Hide();
            usersForm.FormClosed += (s, args) => this.Close();
            usersForm.Show();
        }

        private void button_Orders_Click(object sender, EventArgs e)
        {
            OrdersReportForm ordersReportForm = new OrdersReportForm();
            this.Hide();
            ordersReportForm.FormClosed += (s, args) => this.Close();
            ordersReportForm.Show();
        }

        private void button_Cars_Click(object sender, EventArgs e)
        {
            CarsReportForm carsReportForm = new CarsReportForm();
            this.Hide();
            carsReportForm.FormClosed += (s, args) => this.Close();
            carsReportForm.Show();
        }
    }
}

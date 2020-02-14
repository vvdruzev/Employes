using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employes.Forms;

namespace Employes
{
    public partial class Form1 : Form
    {
        private DB DB;
        public Form1()
        {
            InitializeComponent();
            
            DB = new DB();
           // DB.ShowDialog();

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                NewEmploye n = new NewEmploye();
                n.ShowDialog();
                DB.DBHelper.AddEmployer(n);
            }
            catch (Exception ex)
            {
                var ed = ex;
            }
        }
    }
}

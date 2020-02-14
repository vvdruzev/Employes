using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employes.Forms
{
    public partial class DB : Form
    {


        private DBHelper dBHelper;

        public DBHelper DBHelper
        {
             get
            {
                return dBHelper;
            }
        }


        public DB()
        {
            InitializeComponent();
        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dBHelper = new DBHelper(textBox_DataSourse.Text, textBox_InitialCatalog.Text, textBox_UserId.Text, textBox_Password.Text);
            if  (!DBHelper.connectionOnline)
            {
                MessageBox.Show("Неверные данные");
                return;

            }
        }
    }
}

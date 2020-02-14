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
    public partial class NewEmploye : Form
    {
        private Models.Employe mNewEmployer;

        public Models.Employe NewEmployer
        {
            get
            {
                return mNewEmployer;
            }
        }


        public NewEmploye()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Models.Employe emp = new Models.Employe();
            if (textBox_FullName.Text != string.Empty)
            {
                emp.NewFullName = textBox_FullName.Text;
            }
            else
            {
                MessageBox.Show("Поле имя не должно быть пустым");
                return;
            }
            if (dateTimePicker_Birthday.Value > DateTime.Now.AddYears(-100) && dateTimePicker_Birthday.Value < DateTime.Now.AddYears(-18))
            {
                emp.NewBirthday = dateTimePicker_Birthday.Value;
            }
            else
            {
                MessageBox.Show("Некорректный возраст");
                return;
            }
            if (textBox_SerialNumber.Text != string.Empty)
            {
                emp.NewSerialNumber = textBox_SerialNumber.Text;
            }
            else
            {
                MessageBox.Show("Поле серия/номер не должно быть пустым");
                return;
            }
            if (textBox_TypeDoc.Text != string.Empty)
            {
                emp.NewTypeDoc = textBox_TypeDoc.Text;
            }
            else
            {
                MessageBox.Show("выбирете тип документа");
                return;
            }

            if (dateTimePicker_DateIssue.Value < DateTime.Now.AddDays(-1))
            {
                emp.NewDataIssue = dateTimePicker_DateIssue.Value;
            }
            else
            {
                MessageBox.Show("");
                return;
            }

            if (textBoxAutorIssue.Text != string.Empty)
            {
                emp.NewAutorIssue = textBoxAutorIssue.Text;
            }
            else
            {
                MessageBox.Show("кем выдан");
                return;
            }

            if (textBox_PhoneNumber.Text != string.Empty)
            {
                emp.NewPhoneNumber = textBox_PhoneNumber.Text;
            }
            else
            {
                MessageBox.Show("номер телефона");
                return;
            }

            if (textBox_TypePhone.Text != string.Empty)
            {
                emp.NewTypePhone = textBox_TypePhone.Text;
            }
            else
            {
                MessageBox.Show("тип телефона");
                return;
            }

            if (radioButton_Female.Checked || radioButton_Male.Checked)
            {
                if (radioButton_Female.Checked)
                {
                    emp.NewSex = "1";
                }
                else
                {
                    emp.NewSex = "2";
                }

            }
            else
            {
                MessageBox.Show("Выбирите пол");
                return;

            }


            this.Close();

        }

        private void radioButton_Female_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Male.Checked = false;
        }

        private void radioButton_Male_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Female.Checked = false;
        }
    }
}

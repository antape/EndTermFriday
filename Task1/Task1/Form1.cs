using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (textBoxLogin.Text == "admin" && textBoxPass1.Text == "pt2017" && textBoxPass2.Text == "pt2017")
            {
                MessageBox.Show(textBoxName.Text + " введите другой логин и пароль");
            } else
            if ( textBoxName.Text == " " ||textBoxLogin.Text == "" || textBoxPass1.Text == "" || textBoxPass2.Text == "")
            {
                MessageBox.Show("извините введенные вами регистрационные данные не распознаны!");
            } else
            if (textBoxPass1.Text.Length <=8 && Text.Length <= 8)
            {
                MessageBox.Show("Длинна пароля должна быть более 8 знаков!");
            } else 
            if (textBoxPass1.Text == textBoxPass2.Text && !(textBoxLogin.Text == "admin"))
            {
                MessageBox.Show("Name: " + textBoxName.Text +
                    "\nLogin: " + textBoxLogin.Text +
                    "\nPassword: " + textBoxPass1.Text);
               
            } else
            {
                MessageBox.Show(textBoxName.Text + " введите другой логин");
            }
        }
    }
}

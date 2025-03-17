using System;
using System.Drawing;
using System.Windows.Forms;

namespace My_Login_Form
{
    internal class LoginForm : Form
    {
        // LoginForm 建構子
        public LoginForm()
        {

            InitializeForm(this);

        }

        public void InitializeForm(Form myForm)
        {

            Label lblMessage = new Label();

            lblMessage.Text = "帳號:";

            lblMessage.Location = new Point(50, 50);

            myForm.Controls.Add(lblMessage);

            //

            TextBox tbAccount = new TextBox();

            tbAccount.Width = 150;

            tbAccount.Location = new Point(80, 50);

            myForm.Controls.Add(tbAccount);

            //

            Button btnOK = new Button();

            btnOK.Text = "OK";

            btnOK.Width = 100;

            btnOK.Location = new Point(50, 100);

            myForm.Controls.Add(btnOK);

            //

            btnOK.Click += BtnOK_Click;

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

            System.Console.WriteLine("OK clicked!");

        }
    }
}
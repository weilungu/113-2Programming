using System.Drawing;
using System.Windows.Forms;

namespace My_Login_Form
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form myForm = new LoginForm();

            myForm.Size = new Size(320, 240);

            myForm.Text = "S1131375's Login Form";  // S1135566 請改為自己的學號！
            //

            Application.Run(myForm);
        }
    }
}

namespace Banking_System
{
    public partial class Main : Form
    {
        Login loginClass;
        Find_Form findForm;
        Register_Form registerForm;

        public Main()
        {
            InitializeComponent();
            loginClass = new Login("localhost", "dbtest", "root", "0000");
            
            findForm = new Find_Form();
            registerForm = new Register_Form();
        }

        private void Login_Button_Click(object sender, EventArgs e) => loginClass.UserLogin(ID_TextBox.Text, PW_TextBox.Text);

        private void Find_Button_Click(object sender, EventArgs e) => findForm.Show();
        

        private void Register_Button_Click(object sender, EventArgs e) => registerForm.Show();
    }
}
using trabalho.Model.Authenticação;

namespace projetoPOO
{
    public partial class Form1 : Form
    {

        private string Email { get; set; }
        private string Senha { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Email = textBox1.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Senha = textBox2.Text;
        }

        private void Login(object sender, EventArgs e)
        {
            var auth = new Autenticação();
            var res = auth.Autenticar(Email, Senha);

            if (res == false)
            {
                textBox1.Text = "Incorreto";
                textBox2.Text = "Incorreto";
                return;
            }

            var formFunc = new FormFuncionario();
            formFunc.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var newFunc = new CreateFunc();
            newFunc.Show();
        }
    }
}

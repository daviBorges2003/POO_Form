using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trabalho.Model;
using trabalho.Model.Authenticação;

namespace projetoPOO
{
    public partial class CreateFunc : Form
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public CreateFunc()
        {
            InitializeComponent();
        }

        private void CreateFunc_Load(object sender, EventArgs e)
        {
            Cadastrado.Visible = false;
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            Nome = NameBox.Text;
        }

        private void CpfBox_TextChanged(object sender, EventArgs e)
        {
            Cpf = CpfBox.Text;
        }

        private void EmailBOX_TextChanged(object sender, EventArgs e)
        {
            Email = EmailBOX.Text;
        }

        private void SenhaBOX_TextChanged(object sender, EventArgs e)
        {
            Senha = EmailBOX.Text;
        }

        private void CadastroFunc_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario newFunc = new Funcionario(Id + 1,Nome, Email, Cpf, Senha, 1, 2500);
                var auth = new Autenticação();

                auth.RegistrarPessoa(newFunc);

                Cadastrado.Visible = true;
            }
            catch (Exception ex) 
            {
                Cadastrado.Text = "Error";
                Cadastrado.BackColor = Color.Red;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trabalho.interfaces;

namespace trabalho.Model.Authenticação
{
    public class Autenticação : iAuth
    {
        private List<Pessoa> usuariosRegistrados;

        public Autenticação()
        {
            usuariosRegistrados = new List<Pessoa>();
        }

        public void RegistrarPessoa(Pessoa pessoa)
        {
            usuariosRegistrados.Add(pessoa);
        }

        public bool Autenticar(string email, string senha)
        {

            if (email == "adm" && senha == "1234")
            {
                return true;
            }

            foreach (var pessoa in usuariosRegistrados)
            {


                if (pessoa.Email == email && pessoa.Senha == senha)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
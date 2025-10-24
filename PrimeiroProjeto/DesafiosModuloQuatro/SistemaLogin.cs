using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.DesafiosModuloQuatro
{
    public static class SistemaLogin
    {
        public static void Run() {

            Dictionary<string, string> loginSenha = new Dictionary<string, string>();

            Console.Write("Digite um nome de usuário para login:");
            string usuarioLogin = Console.ReadLine()!;

            Console.Write("Digite uma senha para login:");
            string usuarioPassword = Console.ReadLine()!;

            loginSenha.Add(usuarioLogin, usuarioPassword);


            foreach (KeyValuePair<string, string> kvp in loginSenha) {
                Console.WriteLine($"Você registrou o usuário {kvp.Key} com a senha {kvp.Value}");
            }
                
        }
    }
}

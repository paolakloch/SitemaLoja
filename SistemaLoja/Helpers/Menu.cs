using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoja.Helpers
{
    
        public class Menu
        {

            private Usuario user = new Usuario();  

            public List<Usuario> ListaUsuarios { get; set; } = new List<Usuario>();

            public string MenuPrincipal()
            {
                Console.Clear();
                Console.WriteLine("Bem vindo(a) ao Sistema de Gerenciamento e Controle de Vendas");
                Console.WriteLine();

                Console.WriteLine("1 -- Cadastro -- Crie um perfil de vendedor");
                Console.WriteLine("2 -- Login -- Entre na sua conta");
                Console.WriteLine("3 -- Sair -- Fecha o programa");
                Console.WriteLine();

                Console.WriteLine("Escolha uma opção para prosseguir:");
                return Console.ReadLine();

            }

           
            public void ExibirMenu()
            {

               
                switch (MenuPrincipal()) 
                {
                    case "1":
                        SignUpUser(); 
                        break;
                    case "2":
                        LogInUser(); 
                        break;
                    case "3":
                        Console.WriteLine("Fechando o programa...");
                        break;
                    default:
                        Console.WriteLine("Oops! Algo deu errado, tente novamente");
                        break;
                }

            }
            private void SignUpUser()
            {

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Digite as informações necessárias para cadastrar a sua conta no sistema:");

                Console.WriteLine();
                Console.WriteLine("Usuãrio:");
                Usuario usuario = new Usuario();

                usuario.Username = Console.ReadLine();

                if (ListaUsuarios.Exists(usuarioLista => usuarioLista.Username == usuario.Username))
                {
                    Console.WriteLine("Este nome de usuário já está sendo utilizado, escolha outra opção");
                    return; // [TODO: tentar fazer ele retornar menu]
                }

                Console.WriteLine();
                Console.WriteLine("Senha:");
                usuario.Password = Console.ReadLine();

                ListaUsuarios.Add(usuario);
                Console.WriteLine();
                Console.WriteLine("Cadastro realizado com sucesso!");
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal...");
                Console.ReadKey(); 
                Console.Clear();
                ExibirMenu();

            }
          
            private bool LogInUser() 
            {

                Console.WriteLine("Digite seu usuãrio e senha:");

                Console.WriteLine("Usuãrio:");
                string username = Console.ReadLine();

                Console.WriteLine("Senha:");
                string password = Console.ReadLine();

                Usuario usuario = ListaUsuarios.Find(usuarioLista => usuarioLista.Username == username && usuarioLista.Password == password);

                if (usuario != null)
                {
                    Console.WriteLine("Logado");
                    ExibirMenuLojista(); 

                    return true;

                    //[TODO: continuar o sistema CRUD]
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Senha ou usuário incorreto");
                    Console.WriteLine();
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    ExibirMenu(); 

                    return false;
                }

            }

            private string MenuLojista()
            {
                Usuario user = new Usuario();
                Console.Clear();
                Console.WriteLine($"Olá {user.Username}!");//Não está chamando, por que? Criar função no Usuario pedindo nome

                Console.WriteLine();
                Console.WriteLine("1 -- Clientes -- Veja os seus clientes");
                Console.WriteLine("2 -- Produtos -- Adicione, altere ou remova produtos");
                Console.WriteLine("3 -- Eventos -- "); 
                Console.WriteLine("4 -- Caixa -- "); 
                Console.WriteLine("5 -- Sair -- Volta ao menu principal");

                Console.WriteLine();
                Console.WriteLine("Escolha uma opção para prosseguir");

                return Console.ReadLine();

            }

            public void ExibirMenuLojista()
            {

                switch (MenuLojista())
                {
                    case "1":
                        Console.WriteLine("oi");
                        // Acessa os clientes
                        break;
                    case "2":
                        // Acessa os produtos
                        break;
                    case "3":
                        Console.WriteLine("Fechando o programa...");
                        break;
                    // Acessa os eventos
                    case "4":
                        Console.WriteLine();
                        // Acessa caixa
                        break;
                    case "5":
                        ExibirMenu();
                        break;
                    default:
                        Console.WriteLine("Oops! Algo deu errado, tente novamente");
                        break;
                }


            }


        }
    }


using System;
using System.Collections.Generic;
using System.Linq;


namespace MyProjects
{
    class Program
    {
        private const int V = 2;

        static void Main(string[] args){

            Console.Clear();
            int opMenu = 1;
            while (opMenu != 0){
                Console.WriteLine("Bem vindo!");
                Console.WriteLine("Escolha uma das seguintes opções");
                Console.WriteLine("1- Calculadora!");
                Console.WriteLine("2 - Lista de numeros");
                Console.WriteLine("0 - Sair");


              opMenu  = Int32.Parse (Console.ReadLine());

              if (opMenu == 0 ){

                  break;
              } else if (opMenu == 1 ){

                  Calculadora();
              } else if (opMenu == 2 ){
                  ListaNumeros();
              }else {
                  Console.WriteLine("Opcão invalida, tente novamente");
              }


            }
        }

        private static void Calculadora()
        {
           
            int opMenu=1;
            while (opMenu != 0){
                 Console.Clear();
                Console.WriteLine("Menu Calculadora");
                Console.WriteLine("1 - Somar");

                Console.WriteLine ("2 - Subtrair");
                Console.WriteLine("0 . Voltar ao menu Anterior");

              
                opMenu = Int32.Parse(Console.ReadLine());
                
               switch (opMenu)
               {
                    case 1:
                        Somar();
                        break;
                    case 2:
                     Subtrair();
                     break;
                    default:
                     Console.WriteLine("Opção invalida");
                     break;
               }
            }

        }

        private static void Subtrair()
        {

            int n1,n2;
            Console.Clear();
            Console.WriteLine("Escrena aqui o seu primeiro numero: ");
                n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escrena aqui o seu segundo  numero: ");
                n2 = Int32.Parse(Console.ReadLine());


            Console.WriteLine("A subtração é:  "+(n1-n2));
            Console.ReadKey();
        }

      
    

        private static void Somar()
        {

            int n1,n2;

            Console.WriteLine("Escrena aqui o seu primeiro numero: ");
                n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escrena aqui o seu segundo  numero: ");
                n2 = Int32.Parse(Console.ReadLine());


            Console.WriteLine("A soma é:  "+(n1+n2));
            Console.ReadKey();
        }

        private static void ListaNumeros()
        { 
            int n1, n2;

            Console.WriteLine("Insira o Primeiro Número: ");
                n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número: ");
                n2 = Int32.Parse(Console.ReadLine());

                Console.Clear();

            Console.WriteLine("A lista de números é: ");


            for (int i = n1; i <= n2; i++){
                Console.WriteLine(i);
            }
         

        }
    }
    }

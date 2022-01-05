using System;

namespace ATM
{
    class Program
    {

        double taxaPagemento = 0.01;
        double taxaDeposito = 0.02;
        double taxaLevamento = 0.05;

        static void Main(string[] args)
{
        double saldo = 100;
        int opMenu = 1;
        while(opMenu != 0) {
            Console.WriteLine ("Essolha uma operação");
            Console.WriteLine ("1- Pagamentos");
            Console.WriteLine ("2- Depositos");
            Console.WriteLine ("3- Levantamentos");
            Console.WriteLine ("0- Saor");

            opMenu = Int32.Parse(Console.ReadLine());


            switch (opMenu){
                case 0:
                    break;
                case 1:
                  saldo = pagamento(saldo);
                    break;
                case 2:
                    saldo = Deposito(saldo);
                    break;
                case 3:
                   saldo = levantamento(saldo);
                    break;
                case 4:
                Console.WriteLine(" Opção Inválida");
                Console.ReadKey();
                break;

            }

        }
    }

        private static double levantamento(double saldo)
        {
            Console.Clear();
            Console.WriteLine(" Qual o valor a levantar? ");
            double valor = double.Parse(Console.ReadLine());
            if(  saldo += valor + (valor * taxalevantamento <= 0){
                Console.WriteLine(" levantamento efetuado, o seu saldo é:" +saldo);
            }else{
                Console.WriteLine("Saldo insuficiente.");

        }

        private static double Deposito(double saldo)
        {
            Console.Clear();
            Console.WriteLine(" Qual o valor a depositar? ");
            double valor = double.Parse(Console.ReadLine());
            saldo += valor - (valor * taxaDeposito);
        }

        private static double pagamento(double saldo)
        {
               Console.Clear();
            Console.WriteLine(" Qual o valor do Pagamento? ");
            double valor = double.Parse(Console.ReadLine());

            if(  saldo += valor + (valor * taxaPagamento <= 0){
                Console.WriteLine(" Pagamento efetuado, o seu saldo é:" +saldo);
            }else{
                Console.WriteLine("Saldo insuficiente.");
            }
            
        }
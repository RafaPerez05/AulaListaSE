using System;
namespace AulaListaSE{

    class Program{
        static void Main(string[] args){

            //--CONSULTA

            //No noAtual = null;
            //No noAnterior = null;
            //Boolean encontrou = lista.consulta(12, ref noAtual, ref noAnterior);
            //if(encontrou){
                //Console.WriteLine("Encontrou o no de valor: " + noAtual.valor);
            //}
            //else{
             //   Console.WriteLine("Não encontrou o no procurado!");
            //}

            Lista lista = new Lista();

            //Exibindo os funcionários da lista


            while (true)
            {
                Console.Write("Escolha:");
                Console.Write("\nInserir -> 1");
                Console.Write("\nInserir no Fim -> 2");
                Console.Write("\nBuscar -> 3");
                Console.Write("\nRemover -> 4");
                Console.Write("\nRemover Fim -> 5");
                Console.Write("\nPercuso -> 6\n");
                Console.Write("SAIR -> 7\n\n");
                lista.escolhido = Convert.ToInt32(Console.ReadLine());

                if (lista.escolhido >= 1 && lista.escolhido <= 6)
                {
                    lista.Escolha();
                }
                else if (lista.escolhido == 7)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                }

        }
    }
}
}



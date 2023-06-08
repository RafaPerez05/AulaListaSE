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
                
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1. Inserir disciplina ordenada");
                Console.WriteLine("2. Buscar disciplina");
                Console.WriteLine("3. Remover disciplina");
                Console.WriteLine("4. Exibir disciplinas");
                Console.WriteLine("5. Sair");

                int escolhido = int.Parse(Console.ReadLine());

switch (escolhido)
{
    case 1:
        Console.WriteLine("Digite o nome da disciplina:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o período da disciplina:");
        int periodo = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a carga horária da disciplina:");
        int cargaHoraria = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o nome do professor responsável:");
        string professorResponsavel = Console.ReadLine();

        Disciplina disciplina = new Disciplina()
        {
            Nome = nome,
            Periodo = periodo,
            CargaHoraria = cargaHoraria,
            ProfessorResponsavel = professorResponsavel
        };

        lista.InserirOrdenado(disciplina);
        break;

    case 2:
        Console.WriteLine("Digite o nome da disciplina a ser buscada:");
        string disciplinaBuscada = Console.ReadLine();

        if (lista.Buscar(disciplinaBuscada))
        {
            Console.WriteLine($"A disciplina {disciplinaBuscada} existe na lista.");
        }
        else
        {
            Console.WriteLine($"A disciplina {disciplinaBuscada} não existe na lista.");
        }
        break;

    case 3:
        Console.WriteLine("Digite o nome da disciplina a ser removida:");
        string disciplinaRemovida = Console.ReadLine();
        lista.Remover(disciplinaRemovida);
        break;

    case 4:
        lista.Exibir();
        break;

    case 5:
        Environment.Exit(0);
        break;

    default:
        Console.WriteLine("Opção inválida. Digite um número válido.");
        break;
}

Console.WriteLine();


        }
    }
}
}



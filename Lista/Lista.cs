//estrutura do MENU
public class Funcionario
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Telefone { get; set; }
    public double Salario { get; set; }
}

public class No
{
    public Funcionario Dado { get; set; }
    public No Proximo { get; set; }
}

public class Lista
{
    public No primeiro;
    public No ultimo;

    public void AdicionarInicio(Funcionario funcionario)
{
    No novoNo = new No()
    {
        Dado = funcionario,
        Proximo = primeiro
    };

    primeiro = novoNo;

    if (ultimo == null)
        {
        ultimo = primeiro;
        }
    }
    public void AdicionarFim(Funcionario funcionario)
    {
        No novoNo = new No()
        {
            Dado = funcionario,
            Proximo = null
        };

        if (primeiro == null)
        {
            primeiro = novoNo;
            ultimo = novoNo;
        }
        else
        {
            ultimo.Proximo = novoNo;
            ultimo = novoNo;
        }
    }
    

    public void Exibir()
    {
        No atual = primeiro;

        while (atual != null)
        {
            Console.WriteLine($"Nome: {atual.Dado.Nome}, Idade: {atual.Dado.Idade}, Telefone: {atual.Dado.Telefone}, Salário: {atual.Dado.Salario}");
            atual = atual.Proximo;
        }
    }

        public int escolhido;
        public string nome;
        public int idade;
        public string telefone;
        public double salario;
        public void Escolha(){

        //adcionar no inicio
        if(escolhido==1){
        Console.Write("Digite o nome: ");
        nome = Console.ReadLine();

        Console.Write("Digite a idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o telefone: ");
        telefone = Console.ReadLine();

        Console.Write("Digite o salário: ");
        salario = Convert.ToDouble(Console.ReadLine());

        AdicionarInicio(new Funcionario() { Nome = nome, Idade = idade, Telefone = telefone, Salario = salario });
        Console.WriteLine("Funcionário adicionado com sucesso ao inicio da lista!");

         }
         //adcionar no fim
            else if(escolhido==2){
            Console.Write("Digite o nome:\n");
            nome = Convert.ToString(Console.ReadLine());

            Console.Write("Digite a idade:\n");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Telefone:\n");
            telefone = Convert.ToString(Console.ReadLine());

            Console.Write("Digite o Salario:\n");
            salario = Convert.ToDouble(Console.ReadLine());

            AdicionarFim(new Funcionario() { Nome = nome, Idade = idade, Telefone = telefone, Salario = salario });
            Console.WriteLine("Funcionário adicionado com sucesso ao final da lista!");

        }
            //buscar
            else if(escolhido==3){
            Console.Write("Digite o nome a ser buscado: ");
            string nomeBusca = Console.ReadLine();

            No atual = primeiro;
            bool encontrado = false;

            while (atual != null)
            {
             if (atual.Dado.Nome.ToLower() == nomeBusca.ToLower())
            {
            Console.WriteLine($"Funcionário encontrado - Nome: {atual.Dado.Nome}, Idade: {atual.Dado.Idade}, Telefone: {atual.Dado.Telefone}, Salário: {atual.Dado.Salario}");
            encontrado = true;
            }

            atual = atual.Proximo;
            }

    if (!encontrado)
    {
        Console.WriteLine("Funcionário não encontrado.");
    }
            
         }
            //remover no inicio
            else if(escolhido==4){

            if (primeiro == null){
            Console.WriteLine("A lista está vazia. Não há funcionários para remover.");
            }

             else
            {
                Funcionario funcionarioRemovido = primeiro.Dado;
                primeiro = primeiro.Proximo;

            if (primeiro == null){
                 ultimo = null;
            }
            Console.WriteLine($"Funcionário removido do início da lista - Nome: {funcionarioRemovido.Nome}, Idade: {funcionarioRemovido.Idade}, Telefone: {funcionarioRemovido.Telefone}, Salário: {funcionarioRemovido.Salario}");
            }

         }
            //remover no fim
            else if(escolhido==5){

            if (ultimo == null){
                Console.WriteLine("A lista está vazia. Não há funcionários para remover.");
            }
            else{
            if (primeiro == ultimo){
            Funcionario funcionarioRemovido = primeiro.Dado;
            primeiro = null;
            ultimo = null;
            Console.WriteLine($"Funcionário removido do fim da lista - Nome: {funcionarioRemovido.Nome}, Idade: {funcionarioRemovido.Idade}, Telefone: {funcionarioRemovido.Telefone}, Salário: {funcionarioRemovido.Salario}");
            }

            else{
            No atual = primeiro;
            No anterior = null;

            while (atual.Proximo != null)
            {
                anterior = atual;
                atual = atual.Proximo;
            }

            Funcionario funcionarioRemovido = atual.Dado;
            anterior.Proximo = null;
            ultimo = anterior;
            Console.WriteLine($"Funcionário removido do fim da lista - Nome: {funcionarioRemovido.Nome}, Idade: {funcionarioRemovido.Idade}, Telefone: {funcionarioRemovido.Telefone}, Salário: {funcionarioRemovido.Salario}");
                }
            }            
         }
            //exibir
            else if( escolhido == 6){
            Exibir();
            }
    

    }
}
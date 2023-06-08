using System;

public class Disciplina
{
    public string Nome { get; set; }
    public int Periodo { get; set; }
    public int CargaHoraria { get; set; }
    public string ProfessorResponsavel { get; set; }
}

public class No
{
    public Disciplina Dado { get; set; }
    public No Proximo { get; set; }
}

public class Lista
{
    private No primeiro;
    private No ultimo;

    public void InserirOrdenado(Disciplina disciplina)
    {
        No novoNo = new No()
        {
            Dado = disciplina,
            Proximo = null
        };

        if (primeiro == null)
        {
            primeiro = novoNo;
            ultimo = novoNo;
        }
        else if (string.Compare(disciplina.Nome, primeiro.Dado.Nome, StringComparison.OrdinalIgnoreCase) <= 0)
        {
            novoNo.Proximo = primeiro;
            primeiro = novoNo;
        }
        else if (string.Compare(disciplina.Nome, ultimo.Dado.Nome, StringComparison.OrdinalIgnoreCase) >= 0)
        {
            ultimo.Proximo = novoNo;
            ultimo = novoNo;
        }
        else
        {
            No atual = primeiro;

            while (atual.Proximo != null && string.Compare(disciplina.Nome, atual.Proximo.Dado.Nome, StringComparison.OrdinalIgnoreCase) > 0)
            {
                atual = atual.Proximo;
            }

            novoNo.Proximo = atual.Proximo;
            atual.Proximo = novoNo;
        }

        Console.WriteLine("Disciplina inserida com sucesso!");
    }

    public bool Buscar(string nome)
    {
        No atual = primeiro;

        while (atual != null)
        {
            if (string.Compare(atual.Dado.Nome, nome, StringComparison.OrdinalIgnoreCase) == 0)
            {
                return true;
            }

            atual = atual.Proximo;
        }

        return false;
    }

    public void Remover(string nome)
    {
        if (primeiro == null)
        {
            Console.WriteLine("A lista está vazia. Não há disciplinas para remover.");
            return;
        }

        if (string.Compare(primeiro.Dado.Nome, nome, StringComparison.OrdinalIgnoreCase) == 0)
        {
            Disciplina disciplinaRemovida = primeiro.Dado;
            primeiro = primeiro.Proximo;

            if (primeiro == null)
            {
                ultimo = null;
            }

            Console.WriteLine($"Disciplina removida - Nome: {disciplinaRemovida.Nome}, Período: {disciplinaRemovida.Periodo}, Carga Horária: {disciplinaRemovida.CargaHoraria}, Professor Responsável: {disciplinaRemovida.ProfessorResponsavel}");
            return;
        }

        No atual = primeiro;
        No anterior = null;

        while (atual != null && string.Compare(atual.Dado.Nome, nome, StringComparison.OrdinalIgnoreCase) != 0)
        {
            anterior = atual;
            atual = atual.Proximo;
        }

        if (atual == null)
        {
            Console.WriteLine("Disciplina não encontrada na lista.");
            return;
        }

        anterior.Proximo = atual.Proximo;

        if (atual == ultimo)
        {
            ultimo = anterior;
        }

        Console.WriteLine($"Disciplina removida - Nome: {atual.Dado.Nome}, Período: {atual.Dado.Periodo}, Carga Horária: {atual.Dado.CargaHoraria}, Professor Responsável: {atual.Dado.ProfessorResponsavel}");
    }

    public void Exibir()
    {
        No atual = primeiro;

        while (atual != null)
        {
            Console.WriteLine($"Nome: {atual.Dado.Nome}, Período: {atual.Dado.Periodo}, Carga Horária: {atual.Dado.CargaHoraria}, Professor Responsável: {atual.Dado.ProfessorResponsavel}");
            atual = atual.Proximo;
        }
    }
}

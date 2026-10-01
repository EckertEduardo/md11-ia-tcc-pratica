var tarefas = new List<(int Id, string Titulo, bool Concluida)>();
var proximoId = 1;

void Adicionar(string titulo)
{
    tarefas.Add((proximoId++, titulo, false));
}

void Listar()
{
    foreach (var t in tarefas)
    {
        var status = t.Concluida ? "[X]" : "[ ]";
        Console.WriteLine($"{status} #{t.Id} — {t.Titulo}");
    }
}

void Concluir(int id)
{
    bool encontrado = false;
    for (var i = 0; i < tarefas.Count; i++)
    {
        if (tarefas[i].Id == id)
        {
            tarefas[i] = (tarefas[i].Id, tarefas[i].Titulo, true);
            encontrado = true;
        }
    }
    if (!encontrado)
    {
        Console.WriteLine("id solicitado não foi encontrado");
    }
}

Adicionar("Estudar para a avaliação do Módulo 11");
Adicionar("Configurar o CLAUDE.md do projeto");
Adicionar("Criar uma Skill reutilizável");

Console.WriteLine("=== Gerenciador de Tarefas ===");
Listar();

Concluir(1);

// Chamada de teste para mostrar a mensagem de id não encontrado
Concluir(99);

Console.WriteLine();
Console.WriteLine("=== Depois de concluir a tarefa #1 ===");
Listar();

Console.ReadLine();

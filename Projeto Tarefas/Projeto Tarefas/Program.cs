using System;
using System.Collections.Generic;

List<string> tarefas = new List<string>();
List<bool> statusTarefas = new List<bool>();

void ExibirMenu()
{
    Console.Clear();
    Console.WriteLine("===== ASSISTENTE PESSOAL DE TAREFAS =====");
    Console.WriteLine("1 - Adicionar Tarefa");
    Console.WriteLine("2 - Listar Tarefas");
    Console.WriteLine("3 - Marcar Tarefa como Concluída");
    Console.WriteLine("4 - Excluir Tarefa");
    Console.WriteLine("5 - Exibir Resumo das Tarefas");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");
}

void AdicionarTarefa()
{
    Console.Write("Digite a nova tarefa: ");
    string? novaTarefa = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(novaTarefa))
    {
        Console.WriteLine("A tarefa não pode ser vazia.");
        return;
    }

    tarefas.Add(novaTarefa.Trim());
    statusTarefas.Add(false);
    Console.WriteLine("Tarefa adicionada com sucesso!");
}

void ListarTarefas()
{
    if (tarefas.Count == 0)
    {
        Console.WriteLine("Nenhuma tarefa cadastrada.");
        return;
    }

    Console.WriteLine("\n===== LISTA DE TAREFAS =====");
    for (int i = 0; i < tarefas.Count; i++)
    {
        string status = statusTarefas[i] ? "[✔]" : "[ ]";
        Console.WriteLine($"{i + 1}. {status} {tarefas[i]}");
    }
}

int LerIndice(string prompt)
{
    Console.Write(prompt);
    string? entrada = Console.ReadLine();

    if (!int.TryParse(entrada, out int numero))
    {
        return -1;
    }

    return numero - 1;
}

void MarcarComoConcluida()
{
    ListarTarefas();
    if (tarefas.Count == 0) return;

    int indice = LerIndice("Digite o número da tarefa concluída: ");

    if (indice >= 0 && indice < tarefas.Count)
    {
        if (statusTarefas[indice])
        {
            Console.WriteLine("Essa tarefa já está marcada como concluída.");
        }
        else
        {
            statusTarefas[indice] = true;
            Console.WriteLine("Tarefa marcada como concluída!");
        }
    }
    else
    {
        Console.WriteLine("Número inválido.");
    }
}

void ExcluirTarefa()
{
    ListarTarefas();
    if (tarefas.Count == 0) return;

    int indice = LerIndice("Digite o número da tarefa a ser excluída: ");

    if (indice >= 0 && indice < tarefas.Count)
    {
        Console.Write($"Tem certeza que deseja excluir \"{tarefas[indice]}\"? (S/N): ");
        string? confirm = Console.ReadLine();

        if (!string.IsNullOrEmpty(confirm) && confirm.Trim().ToUpper() == "S")
        {
            tarefas.RemoveAt(indice);
            statusTarefas.RemoveAt(indice);
            Console.WriteLine("Tarefa removida com sucesso!");
        }
        else
        {
            Console.WriteLine("Exclusão cancelada.");
        }
    }
    else
    {
        Console.WriteLine("Número inválido.");
    }
}

void ExibirResumo()
{
    int total = tarefas.Count;
    int concluidas = statusTarefas.FindAll(x => x).Count;
    int pendentes = total - concluidas;

    Console.WriteLine("\n===== RESUMO =====");
    Console.WriteLine($"Total de tarefas: {total}");
    Console.WriteLine($"Concluídas: {concluidas}");
    Console.WriteLine($"Pendentes: {pendentes}");
}

void Pausar()
{
    Console.WriteLine("\nPressione Enter para continuar...");
    Console.ReadLine();
}

// Loop do programa
while (true)
{
    ExibirMenu();
    string? opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            AdicionarTarefa();
            Pausar();
            break;
        case "2":
            ListarTarefas();
            Pausar();
            break;
        case "3":
            MarcarComoConcluida();
            Pausar();
            break;
        case "4":
            ExcluirTarefa();
            Pausar();
            break;
        case "5":
            ExibirResumo();
            Pausar();
            break;
        case "0":
            Console.WriteLine("Saindo do programa...");
            return;
        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            Pausar();
            break;
    }
}

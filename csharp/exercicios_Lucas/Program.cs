using System;
using System.Collections.Generic;

class Program
{
  static List<string> pendentes = new List<string>();
  static List<string> completadas = new List<string>();

  static void Main()
  {
    Console.WriteLine("Bem-vindo à sua Lista de Tarefas!\n");

    while (true)
    {
      Console.Clear();

      ShowMenu();

      Console.WriteLine("\n######################### MENU ########################");
      Console.WriteLine("Escolha uma opção:");
      Console.WriteLine("A. dicionar tarefa");
      Console.WriteLine("B. Remover tarefa");
      Console.WriteLine("C. Completar tarefa");
      Console.WriteLine("E. Sair");

      Console.Write("\nDigite sua opção: ");
      string escolha = Console.ReadLine()?.Trim().ToUpper();

      Console.Clear();

      switch (escolha)
      {
        case "A":
          AddItem();
          break;

        case "B":
          RemoveItem();
          break;

        case "C":
          CompleteItem();
          break;

        case "E":
          Console.WriteLine("\nAté mais! Saindo do programa...");
          return;

        default:
          Console.WriteLine("Opção inválida! Tente novamente.");
          break;
      }

      Console.WriteLine("\nPressione ENTER para continuar...");
      Console.ReadLine();
    }
  }


  static void ShowMenu()
  {
    Console.WriteLine($"[{pendentes.Count}] Tarefas pendentes:\n");

    for (int i = 0; i < pendentes.Count; i++)
    {
      Console.WriteLine($"   {i + 1}) {pendentes[i]}");
    }

    Console.WriteLine($"\n[{completadas.Count}] Tarefas concluídas:\n");

    for (int i = 0; i < completadas.Count; i++)
    {
      Console.WriteLine($"   {i + 1}) {completadas[i]}");
    }
  }

  static void AddItem()
  {
    Console.WriteLine("=== Adicionar Tarefa ===\n");
    Console.Write("Digite a tarefa que deseja adicionar: ");
    string tarefa = Console.ReadLine()?.Trim();

    if (!string.IsNullOrEmpty(tarefa))
    {
      pendentes.Add(tarefa);
      Console.WriteLine("Tarefa adicionada com sucesso!");
    }
    else
    {
      Console.WriteLine("Tarefa não pode estar vazia.");
    }
  }

  static void RemoveItem()
  {
    Console.WriteLine("=== Remover Tarefa ===\n");

    if (pendentes.Count == 0)
    {
      Console.WriteLine("Não há tarefas pendentes para remover.");
      return;
    }

    ShowPendingTasks();

    Console.Write("\nDigite o número da tarefa que deseja remover: ");
    if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 1 && numero <= pendentes.Count)
    {
      string removida = pendentes[numero - 1];
      pendentes.RemoveAt(numero - 1);
      Console.WriteLine($"\nTarefa removida: \"{removida}\"");
    }
    else
    {
      Console.WriteLine("Número inválido!");
    }
  }

  static void CompleteItem()
  {
    Console.WriteLine("=== Completar Tarefa ===\n");

    if (pendentes.Count == 0)
    {
      Console.WriteLine("Não há tarefas pendentes para completar.");
      return;
    }

    ShowPendingTasks();

    Console.Write("\nDigite o número da tarefa concluída: ");
    if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 1 && numero <= pendentes.Count)
    {
      string concluida = pendentes[numero - 1];
      pendentes.RemoveAt(numero - 1);
      completadas.Add(concluida);
      Console.WriteLine($"\nTarefa concluída: \"{concluida}\"");
    }
    else
    {
      Console.WriteLine("Número inválido!");
    }
  }


  static void ShowPendingTasks()
  {
    for (int i = 0; i < pendentes.Count; i++)
    {
      Console.WriteLine($"  {i + 1}) {pendentes[i]}");
    }
  }
}
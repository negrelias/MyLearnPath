using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


class Program{


// com o metedo static eu posso usar a minha lista em qualquer lugar do codigo.
 static List<string> pendents = new List <string>();
 static List<string> completed = new List <string>();

 static void Main()
    {

        Console.WriteLine($"Welcome to do list simple\n");


        while (true)
       {
            
          Console.Clear(); // aqui vou começa a limpa o menu 

          // posso criar um metedo aonde posso chama o menu 


          showTheMenu();


          //Console.WriteLine($"#########################Menu####################\n");
          Console.WriteLine($"\n#########################Menu####################\n");
          Console.WriteLine($"Escolha um Item\n");
          Console.WriteLine($"A. Item");
          Console.WriteLine($"B. Remove");
          Console.WriteLine($"C. complete Item");
          Console.WriteLine($"E. sair\n");


          // estou usando otrim para remover os espaças em brancos, e tambem estou usando o ? para caso o usario colocar alguma coisa
          // null o sistema não faz nada.

          Console.WriteLine($"Qual opção escolhes:\n");

          string userChoose = Console.ReadLine()? .Trim().ToUpper();

          Console.Clear();


          switch (userChoose)
          {
            case "A":

            addItem();

            break;


            case "B":

            //removeItem();

            break;


            case "C":

           // completeItem();

            break;

            case "E":

            Console.WriteLine($"\nAté mais, saindo...");

            return;

            default:

            Console.WriteLine($"Opção invalida");

            break;

             }


             Console.WriteLine("\nPressione ENTER para continuar...");
             Console.ReadLine();
            
            }
        
          
          static  void showTheMenu()

          {

            Console.WriteLine($"[{pendents.Count()}]Peding task\n");


            for (int i = 0; i < pendents.Count; i++)
            {
                Console.WriteLine($"   {i + 1}) {pendents[i]}");
            }



          Console.WriteLine($"[{pendents.Count()}]Peding task");


          for (int i = 0; i < completed.Count; i++)
            {
                Console.WriteLine($"   {i + 1}) {completed[i]}");
            }



     }


     static void addItem()
        {
            Console.WriteLine("Adiciona item:\n");
            Console.WriteLine($"Coloqui escreva o item que quer adicionar");
            string tarefa = Console.ReadLine()?.Trim();

            pendents.Add(tarefa);

        }






    }










}


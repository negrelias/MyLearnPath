
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{

    static void Main()
    {

        // This list have the exercice need to be done.

        List<string> removeExerciceAfterDone = new List<string>() { "Create a consonle", "Manege list", "Add item", "Remove item", "Update item" };

        // This is the code that confirm the console is created.

        Console.WriteLine($"Hello Lucas, console aplication is created.\n");

        //This code indicate after remove how many exercise is left to be done.

        removeExerciceAfterDone.Remove("Create a consonle");

        Console.WriteLine($"The excercise  create a console is done, Remains to complete: {string.Join(", ", removeExerciceAfterDone)}\n");

        // create a segund list

        List<string> fruit = new List<string>() { "Banana", "Pera", "maça" };

        Console.WriteLine($"The new list is about fruit is: {string.Join(", ", fruit)}\n");

        removeExerciceAfterDone.Remove("Manege list");

        Console.WriteLine($"The excercise  manage list is done, Remains to complete: {string.Join(", ", removeExerciceAfterDone)}\n");

        fruit.Add("Laranja");

        Console.WriteLine($"The new component in the lits is laranja: {string.Join(", ", fruit)}\n");

        removeExerciceAfterDone.Remove("Add item");

        Console.WriteLine($"I add in the lis Laranja. The excercise add item is done, Remains to complete: {string.Join(", ", removeExerciceAfterDone)}\n");

        fruit.Remove("Pera");

        Console.WriteLine($"The list of fruit is: {string.Join(", ", fruit)}\n");

        removeExerciceAfterDone.Remove("Remove item");

        Console.WriteLine($"I remove pera from the list. The excercise remove item is done, Remains to complete: {string.Join(", ", removeExerciceAfterDone)}\n");

        fruit[0] = "Abacaxi";

        removeExerciceAfterDone.Remove("Update item");

        Console.WriteLine($"I update the first item in the list. The excercise update item is done, Remains to complete: {string.Join(", ", removeExerciceAfterDone)}\n");


    }

}

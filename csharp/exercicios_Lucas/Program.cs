
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{

    static void Main()
    {

        // This list have the exercise need to be done.

        List<string> removeExerciceAfterDone = new List<string>() { "Create a consonle", "Manege list", "Add item", "Remove item", "Update item" };

        // This is the code that confirm the console is created.

        Console.WriteLine($"Hello Lucas, console aplication is created.\n");

        //This code indicate after remove how many exercise is left to be done.

        removeExerciceAfterDone.Remove("Create a consonle");

        Console.WriteLine($"The excercise  create a console is done, Remains to complete: {string.Join(", ", removeExerciceAfterDone)}\n");

        // create a segund list

        List<string> fruit = new List<string>() { "Banana", "Pera", "maça" };

        Console.WriteLine($"The new list is about fruit is: {string.Join(", ", fruit)}\n");

        // remove the exercise manage list and show how many exercise is left to be done.

        removeExerciceAfterDone.Remove("Manege list");

        Console.WriteLine($"The excercise  manage list is done, Remains to complete: {string.Join(", ", removeExerciceAfterDone)}\n");

        //add a new item in the list and show the new list, remove the exercise add item and show how many exercise is left to be done.

        fruit.Add("Laranja");

        Console.WriteLine($"The new component in the lits is laranja: {string.Join(", ", fruit)}\n");

        // remove the exercise add item and show how many exercise is left to be done.

        removeExerciceAfterDone.Remove("Add item");

        Console.WriteLine($"I add in the lis Laranja. The excercise add item is done, Remains to complete: {string.Join(", ", removeExerciceAfterDone)}\n");

        // remove the item pera from the list and show the new list, remove the exercise remove item and show how many exercise is left to be done.

        fruit.Remove("Pera");

        Console.WriteLine($"The list of fruit is: {string.Join(", ", fruit)}\n");

        // remove the exercise remove item and show how many exercise is left to be done.

        removeExerciceAfterDone.Remove("Remove item");

        Console.WriteLine($"I remove pera from the list. The excercise remove item is done, Remains to complete: {string.Join(", ", removeExerciceAfterDone)}\n");


        // update the item in the list and show the new list, remove the exercise update item and show how many exercise is left to be done.
        fruit[0] = "Abacaxi";

        //remove the exercise update item and show how many exercise is left to be done.

        removeExerciceAfterDone.Remove("Update item");

        Console.WriteLine($"I update the first item in the list. The excercise update item is done, Remains to complete: {string.Join(", ", removeExerciceAfterDone)}\n");

    }

}

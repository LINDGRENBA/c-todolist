using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList {

  public class Program
  {
    public static List<Item> catList = new List<Item> { };
    public static void Main ()
    {
        Console.WriteLine("Welcome to YOUR To-Do List!");
        Console.WriteLine("Would you like to add an item to your list or view your list? [ADD / VIEW]");
        string userInput = Console.ReadLine().ToUpper();

        if(userInput == "ADD")
        {
          Console.WriteLine("Okay! Let's add something");
        }
        else
        {
          Console.WriteLine("You haven't added anything yet. There's nothing to view.");
        }

    }
    static void AddItem ()
    {

    }

    static void ViewItem ()
    {
      
    }

  }

}

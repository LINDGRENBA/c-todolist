using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList {

  public class Program
  {
    // public static List<Item> catList = new List<Item> { };
    public static void Main ()
    {
        Console.WriteLine("Welcome to YOUR To-Do List!");
        Console.WriteLine("Would you like to add an item to your list or view your list? [ADD / VIEW]");
        string userInput = Console.ReadLine().ToUpper();

        if(userInput == "ADD")
        {
          // ask user to input the item string - store it in a string variable userItem
          // Item newCatItem1 = new Item("pet kitty");
          // if(newCatItem1)
          // {
          // // confirm to user that the string(variable) has been added
          // }

        }
        else
        {
          Console.WriteLine("You haven't added anything yet. There's nothing to view.");
        }

    }
    static void AddItem ()
    {

      // code to actually add the string to the list

    }

    static void ViewItem ()
    {
      
    }

  }

}

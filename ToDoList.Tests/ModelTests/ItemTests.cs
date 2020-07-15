using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests     
{
  [TestClass]
  public class ItemTests :IDisposable
  {

    public void Dispose()
    {
      // Item.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("kitty");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Brush the cat.";
      Item newItem = new Item(description);
      string result = newItem.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Brush the cat.";
      Item newItem = new Item(description);

      string updatedDescription = "Play and feed the cat";
      newItem.Description = updatedDescription;
      string result = newItem.Description;
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<Item> newList = new List<Item> { };
      List<Item> result = Item.GetAll();
      foreach (Item thisItem in result)
      {
        Console.WriteLine("Output from empty list GetAll test: " + thisItem.Description);
      }
      CollectionAssert.AreEqual(newList, result);
    } 

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      string description01 = "Brush the cat";
      string description02 = "Clean the litterbox";
      Item newItem1 = new Item(description01);
      Item newItem2 = new Item(description02);
      List<Item> newList = new List<Item> { newItem1, newItem2 };

      List<Item> result = Item.GetAll();
      foreach(Item thisItem in result)
      {
        Console.WriteLine("Output from second GetAll test: " + thisItem.Description);
      }

      CollectionAssert.AreEqual(newList, result);
    }

  }
}
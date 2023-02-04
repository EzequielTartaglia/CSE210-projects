using System;
//Public class to can use in "other window"

public class Inventory
{
    //Create a list of items inside it
     public List<Item> _items = new List<Item>();

    public Inventory()
    {
        _items = new List<Item>();
    }

    public void AddItemToInventory(Item name){

        //Add the object Item to the inventary
        _items.Add(name);
    }

    public void Display(){

        
        //Display all the items (information for each element) in the list Inventory
        foreach (Item itemOfList in _items)
        {
         //Display all the information inside the element
         Console.WriteLine($"{itemOfList._name} - {itemOfList._quantity}");
         
        }
    }
}
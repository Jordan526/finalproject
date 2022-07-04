using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Milestone3
{
	class InventoryManager
	{
		//List collection
		List<Item> inventoryList = new List<Item>();
		public void addItemToInventory()
		{
			string itemName;
			double itemPrice;
			int quantity;


			Console.WriteLine("Enter item name ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            itemName = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            Console.WriteLine("Enter item price ");
			itemPrice = Convert.ToDouble(Console.ReadLine());


			Console.WriteLine("Enter item quantity ");
			quantity = Convert.ToInt32(Console.ReadLine());

			//creating new item to add to inventory.
			Item i = new Item(itemName, itemPrice, quantity); 
			inventoryList.Add(i);

		}

		public void displayInventoryItem()
		{
			//display inventory in a nice layout. 
			string inventoryLayout = String.Format("{0,10}{1,10}{2,10}", "name", "price", "quantity");
			Console.WriteLine(inventoryLayout + "\n");

			foreach (Item item in inventoryList)
			{

				string newInventoryLayout = String.Format("{0,10}{1,10}{2,10}", item.ItemName, item.ItemPrice, item.Quantity);
				Console.WriteLine(newInventoryLayout + "\n");

			}


		}

		//removing item from inventory list if item entered by user is found.
		public void removeItemFromInventoryList()
		{

			Console.WriteLine("Enter item name to remove ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string itemName = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            int ifItemNotFoundCase = 0;

			for (int i = 0; i < inventoryList.Count; i++)
			{
				
				if (inventoryList[i].ItemName.Equals(itemName)) 
				{
					inventoryList.RemoveAt(i);
					Console.WriteLine("Item removed");
					ifItemNotFoundCase = 1;
				}
			}		

			if (ifItemNotFoundCase == 0)
				Console.WriteLine("Item not found");

		}

		//Search inventory by name and format neatly. 
		public void searchInventoryItemByName(string name)
		{

			int itemNotFoundCase = 0;
		
			string itemName = String.Format("{0,10}{1,10}{2,10}", "name", "price", "quantity");
			Console.WriteLine(itemName + "\n");

			foreach (Item item in inventoryList)
			{

				if (item.ItemName.Equals(name))
				{
					string inventoryDisplay = String.Format("{0,10}{1,10}{2,10}", item.ItemName, item.ItemPrice, item.Quantity);
					Console.WriteLine(inventoryDisplay + "\n");
					itemNotFoundCase = 1;
				}

			}

			if (itemNotFoundCase == 0)
				Console.WriteLine("Item not found");


		}

		//Search item by price. 
		public void searchItemByPrice(double price)
		{

			int itemNotFoundCase = 0;
			string inventoryLayout = String.Format("{0,10}{1,10}{2,10}", "name", "price", "quantity");
			Console.WriteLine(inventoryLayout + "\n");

			foreach (Item i in inventoryList)
			{

				if (i.ItemPrice == price)
				{
					string newInventoryLayout = String.Format("{0,10}{1,10}{2,10}", i.ItemName, i.ItemPrice, i.Quantity);
					Console.WriteLine(newInventoryLayout + "\n");
					itemNotFoundCase = 1;
				}

			}

			if (itemNotFoundCase == 0)
				Console.WriteLine("Item not found");

		}

		//changing stock quantity for item that wants/needs to be modified by user.
		//prompts the user that the quantity has been modified. 
		public void modifyInventoryItem(string itemName)
		{


			Console.WriteLine("Enter new stock quantity for this item ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string stockQuantity = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            int quantity = Convert.ToInt32(stockQuantity);

			foreach (Item item in inventoryList)
			{


				if (item.Equals(itemName))
				{
					item.Quantity = quantity;
					Console.WriteLine("quantity updated");
				}

			}

		}

	}
}

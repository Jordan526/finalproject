using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Milestone3
{
	class Item
	{

		//Global Variables for easy access
		string itemName;
		double itemPrice;
		int itemQuantity;

		//Constructors
		public Item(string name, double price, int quantity)
		{
			ItemName = name;
			ItemPrice = price;
			Quantity = quantity;
		}

		//Getter/Setters
		public string ItemName { get => itemName; set => itemName = value; }
		public double ItemPrice { get => itemPrice; set => itemPrice = value; }
		public int Quantity { get => itemQuantity; set => itemQuantity = value; }
	}
}


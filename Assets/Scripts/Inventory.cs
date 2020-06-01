using System.Collections.Generic;
using UnityEngine;

public class Inventory : Singleton<Inventory>, IInventory
{
	[SerializeField] private List<InventorySlot> _items = new List<InventorySlot>();

	public void Add(Item item, int quantity = 1)
	{
		if (!Exists(item))
		{
			_items.Add(new InventorySlot(item, quantity));
			return;
		}
		_items.Find(x => x.item == item).AddAmount(quantity);
	}

	public void Remove(Item item, int quantity = 1)
	{
		if (!Exists(item)) { return; }
		_items.Find(x => x.item == item).AddAmount(-quantity);
	}

	public bool Exists(Item item)
	{
		return _items.Find(x => x.item == item) != null;
	}

	public int GetAmount(Item item)
	{
		return _items.Find(x => x.item == item).amount;
	}
}

[System.Serializable]
public class InventorySlot
{
	public Item item;
	public int amount = 0;

	public InventorySlot(Item _item, int _amount = 1)
	{
		item = _item;
		amount = _amount;
	}

	public void AddAmount(int value)
	{
		amount += value;
	}
}
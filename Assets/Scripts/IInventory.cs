interface IInventory
{
    void Add(Item item, int quantity = 0);
    void Remove(Item item, int quantity = 0);
    int GetAmount(Item item);
    bool Exists(Item item);
}
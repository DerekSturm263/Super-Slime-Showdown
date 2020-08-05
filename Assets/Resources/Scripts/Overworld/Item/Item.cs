using UnityEngine;

public class Item
{
    public string ItemName;
    public Sprite Icon;
    public string Description;
    public uint Cost;

    public Item(string itemName, Sprite icon, string description, uint cost)
    {
        ItemName = itemName;
        Icon = icon;
        Description = description;
        Cost = cost;
    }
}

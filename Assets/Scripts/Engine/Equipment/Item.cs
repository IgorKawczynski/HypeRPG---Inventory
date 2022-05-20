using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public static Item item
    {
        get; 
        private set;
    }

    public Sprite icon = null;
    public string item_name = "Nowy przedmiot";
    public string desc = "Opis przedmiotu";
    public float worth;
    public float weight;
    public int stacksize;
    public ItemType type;

    public enum ItemType
    {
        item,
        weapon,
        armor,
        potion,
        food,
        alcohol,
        money
    }
}

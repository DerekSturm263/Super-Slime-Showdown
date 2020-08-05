using UnityEngine;

public class Ingredient : Item
{
    public Type IngredientType;

    public Ingredient(string itemName, Sprite icon, string description, uint cost, Type ingredientType) : base (itemName, icon, description, cost)
    {
        IngredientType = ingredientType;
    }
}

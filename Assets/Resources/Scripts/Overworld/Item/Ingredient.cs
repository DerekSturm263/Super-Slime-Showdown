using UnityEngine;

public class Ingredient : Item
{
    public string Descriptor1; // This adjective will be added to the beginning of whatever meal is cooked.
    public string Descriptor2; // This adjective will be added to the beginning of the description of whatever meal is cooked.
    public string Descriptor3; // This adjective will be added to the end of the description of whatever meal is cooked.

    public Type IngredientType;

    public Ingredient Compliment; // If this ingredient is used in combination with its compliment, the effects will be improved.

    public string CookedName;
    public string CookedDescription;
    public Sprite CookedImage;

    public float Strength; // When a final meal is cooked, all of the strengths will be added together to increase the player's affinities.
    public uint Priority; // When cooking multiple types of ingredients together, the ingredient with the highest priority will be the main ingredient in the meal.

    public Ingredient(string name, string description, string descriptor1, string descriptor2, string descriptor3,
        Type ingredientType, uint cost, Sprite image, Ingredient compliment,
        string cookedName, string cookedDescription, Sprite cookedImage,
        float strength, uint priority)
    {
        Name = name;
        Description = description;
        Descriptor1 = descriptor1;
        Descriptor2 = descriptor2;
        Descriptor3 = descriptor3;
        Cost = cost;
        Image = image;
        IngredientType = ingredientType;
        Compliment = compliment;
        CookedName = cookedName;
        CookedDescription = cookedDescription;
        CookedImage = cookedImage;
        Strength = strength;
        Priority = priority;
    }
}

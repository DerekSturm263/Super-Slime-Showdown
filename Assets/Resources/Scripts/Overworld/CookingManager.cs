using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CookingManager
{
    public static void CookMeal(List<Ingredient> ingredients)
    {
        ingredients.Sort((x, y) => (int)(y.Priority - x.Priority));

        string name = "";
        string description = "";
        Sprite image = null;
        Dictionary<Type, float> typeStrengths = new Dictionary<Type, float>();

        if (ingredients.Count == 1)
        {
            name = ingredients[0].CookedName;
            description = "A yummy " + ingredients[0].CookedDescription + ".";
            image = ingredients[0].CookedImage;
        }
        else if (ingredients.Count == 2)
        {
            name = ingredients[1].Descriptor1 + " " + ingredients[0].CookedName;
            description = "A " + ingredients[1].Descriptor2 + " " + ingredients[0].CookedDescription + ".";
            image = ingredients[0].CookedImage;
        }
        else if (ingredients.Count >= 3)
        {
            name = ingredients[1].Descriptor1 + " " + ingredients[0].CookedName;
            description = "A " + ingredients[1].Descriptor2 + " " + ingredients[0].CookedDescription + " with a hint of " + ingredients[2].Descriptor3 + ".";
            image = ingredients[0].CookedImage;
        }

        foreach (Ingredient i in ingredients)
        {
            if (!typeStrengths.ContainsKey(i.IngredientType))
                typeStrengths.Add(i.IngredientType, i.Strength);
            else
                typeStrengths[i.IngredientType] += i.Strength;
        }

        foreach (Ingredient i in ingredients)
        {
            if (ingredients.Contains(i.Compliment))
            {
                typeStrengths[i.IngredientType] *= 1.5f;
                typeStrengths[i.Compliment.IngredientType] *= 1.5f;
            }
        }

        Meal newMeal = new Meal(name, description, image, typeStrengths);

        foreach (KeyValuePair<Type, float> affinity in newMeal.TypeStrengths)
        {
            PlayerInfo.RaiseAffinity(affinity.Key, affinity.Value);
        }
    }
}

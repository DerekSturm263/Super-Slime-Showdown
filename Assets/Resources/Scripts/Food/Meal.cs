using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meal
{
    public string MealName;
    public Sprite Icon;
    public string Description;

    public List<Ingredient> Ingredients;

    public Meal(string mealName, Sprite icon, string description, List<Ingredient> ingredients)
    {
        MealName = mealName;
        Icon = icon;
        Description = description;
        Ingredients = ingredients;

        Meals.allMeals.Add(this);
    }
}

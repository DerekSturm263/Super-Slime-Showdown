using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CookingManager
{
    public static void CookMeal(List<Ingredient> ingredients)
    {
        Meal cookedMeal;

        foreach (Meal meal in Meals.allMeals)
        {
            if (meal.Ingredients == ingredients)
                cookedMeal = meal;
        }
    }
}

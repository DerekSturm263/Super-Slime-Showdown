using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Meals
{
    public static readonly string path = "Sprites/Overworld/Food/Meals/";
    public static List<Meal> allMeals = new List<Meal>();

    public static Meal Wheat = new Meal("", Resources.Load(path + "meal_", typeof(Sprite)) as Sprite, "", new List<Ingredient> { Ingredients.Wheat } );
    public static Meal SteamedRice = new Meal("Steamed Rice", Resources.Load(path + "meal_steamedRice", typeof(Sprite)) as Sprite, "", new List<Ingredient> { Ingredients.Rice } );
    public static Meal Oats = new Meal("", Resources.Load(path + "meal_", typeof(Sprite)) as Sprite, "", new List<Ingredient> { Ingredients.Oats } );
    public static Meal Lettuce = new Meal("", Resources.Load(path + "meal_", typeof(Sprite)) as Sprite, "", new List<Ingredient> { Ingredients.Lettuce } );
    public static Meal Sugar = new Meal("", Resources.Load(path + "meal_", typeof(Sprite)) as Sprite, "", new List<Ingredient> { Ingredients.Sugar } );
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Ingredients
{
    public static readonly string path = "Sprites/Overworld/Food/Ingredients/";

    // Nature type ingredients.
    public static Ingredient Wheat = new Ingredient("Wheat", Resources.Load(path + "ingredient_wheat", typeof(Sprite)) as Sprite, "", 0, Types.Nature);
    public static Ingredient Rice = new Ingredient("Rice", Resources.Load(path + "ingredient_rice", typeof(Sprite)) as Sprite, "", 0, Types.Nature);
    public static Ingredient Oats = new Ingredient("Oats", Resources.Load(path + "ingredient_oats", typeof(Sprite)) as Sprite, "", 0, Types.Nature);
    public static Ingredient Lettuce = new Ingredient("Lettuce", Resources.Load(path + "ingredient_lettuce", typeof(Sprite)) as Sprite, "", 0, Types.Nature);
    public static Ingredient Sugar = new Ingredient("Sugar", Resources.Load(path + "ingredient_sugar", typeof(Sprite)) as Sprite, "", 0, Types.Nature);

    // Ice type ingredients.
    public static Ingredient IceCube = new Ingredient("Ice Cube", Resources.Load(path + "ingredient_iceCube", typeof(Sprite)) as Sprite, "", 0, Types.Ice);
    public static Ingredient IceCube2 = new Ingredient("Ice Cube2", Resources.Load(path + "ingredient_iceCube", typeof(Sprite)) as Sprite, "", 0, Types.Ice);
    public static Ingredient IceCube3 = new Ingredient("Ice Cube3", Resources.Load(path + "ingredient_iceCube", typeof(Sprite)) as Sprite, "", 0, Types.Ice);
    public static Ingredient IceCube4 = new Ingredient("Ice Cube4", Resources.Load(path + "ingredient_iceCube", typeof(Sprite)) as Sprite, "", 0, Types.Ice);
    public static Ingredient IceCube5 = new Ingredient("Ice Cube5", Resources.Load(path + "ingredient_iceCube", typeof(Sprite)) as Sprite, "", 0, Types.Ice);
}

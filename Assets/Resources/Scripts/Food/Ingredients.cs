using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredients
{
    public static readonly Ingredient Potato = new Ingredient("Raw Potato", "A raw potato.", "Starchy", "starchy", "starch", Types.Nature, 25,
        Sprite.Create(new Texture2D(0, 0), new Rect(), new Vector2(0f, 0f)), Salmon, "Baked Potato", "baked potato", Sprite.Create(new Texture2D(0, 0), new Rect(), new Vector2(0f, 0f)), 1f, 3);

    public static readonly Ingredient Salmon = new Ingredient("Raw Salmon", "An uncooked fish.", "Fishy", "fishy", "fish", Types.Water, 40,
        Sprite.Create(new Texture2D(0, 0), new Rect(), new Vector2(0f, 0f)), Potato, "Smoked Salmon", "smoked salmon", Sprite.Create(new Texture2D(0, 0), new Rect(), new Vector2(0f, 0f)), 2f, 5);

    public static readonly Ingredient Jalapeno = new Ingredient("Jalapeno", "A spicy jalapeno.", "Spicy", "spicy", "spice", Types.Fire, 30,
        Sprite.Create(new Texture2D(0, 0), new Rect(), new Vector2(0f, 0f)), Lemon, "Cooked Jalapeno", "cooked jalapeno", Sprite.Create(new Texture2D(0, 0), new Rect(), new Vector2(0f, 0f)), 2f, 2);

    public static readonly Ingredient Lemon = new Ingredient("Lemon", "A tangy lemon.", "Tangy", "tangy", "tang", Types.Volt, 35,
        Sprite.Create(new Texture2D(0, 0), new Rect(), new Vector2(0f, 0f)), Jalapeno, "Fresh Lemon", "freshly squeezed lemon", Sprite.Create(new Texture2D(0, 0), new Rect(), new Vector2(0f, 0f)), 1f, 2);

    public static readonly Ingredient Candy = new Ingredient("Candy", "A sweet piece of candy.", "Sweet", "sweet", "sweetness", Types.Wind, 20,
        Sprite.Create(new Texture2D(0, 0), new Rect(), new Vector2(0f, 0f)), Potato, "Delicious Candy", "piece of candy", Sprite.Create(new Texture2D(0, 0), new Rect(), new Vector2(0f, 0f)), 1f, 3);
}

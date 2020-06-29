using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meal
{
    public string Name;
    public string Description;

    public Sprite Image;

    public Dictionary<Type, float> TypeStrengths = new Dictionary<Type, float>();

    public Meal(string name, string description, Sprite image, Dictionary<Type, float> typeStrengths)
    {
        Name = name;
        Description = description;
        Image = image;
        TypeStrengths = typeStrengths;
    }
}

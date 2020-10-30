using UnityEngine;

public class Character
{
	public string Name;
	public Sprite Icon;

	public Character(string name, Sprite icon = null)
	{
		Name = name;
		Icon = icon;

		Characters.allCharacters.Add(Name, this);
	}
}

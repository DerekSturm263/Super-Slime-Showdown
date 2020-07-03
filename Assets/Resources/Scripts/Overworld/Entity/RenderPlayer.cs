using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RenderPlayer : MonoBehaviour
{
    private SpriteRenderer sprtRndr;

    private void Awake()
    {
        sprtRndr = GetComponent<SpriteRenderer>();

        RenderColor();

        foreach (Cosmetic c in PlayerInfo.ownedCosmetics)
        {
            RenderCosmetic(c);
        }
    }

    public void RenderColor()
    {
        PlayerInfo.types.Clear();

        var typesList = PlayerInfo.typeAffinities.ToList();
        typesList.Sort((x, y) => (y.Value.CompareTo(x.Value)));
        typesList.ForEach((x) => PlayerInfo.types.Add(x.Key));

        if (PlayerInfo.types.Count == 1 || PlayerInfo.typeAffinities[PlayerInfo.types[0]] != PlayerInfo.typeAffinities[PlayerInfo.types[1]])
        {
            sprtRndr.color = PlayerInfo.types[0].TypeColor;
        }
        else
        {
            sprtRndr.color = Color.Lerp(PlayerInfo.types[0].TypeColor, PlayerInfo.types[1].TypeColor, 0.5f);
        }
    }

    public void RenderCosmetic(Cosmetic item)
    {

    }
}

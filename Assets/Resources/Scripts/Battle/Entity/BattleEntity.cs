using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BattleEntity : MonoBehaviour
{
    private SpriteRenderer sprtRndr;

    private void Awake()
    {
        sprtRndr = GetComponent<SpriteRenderer>();
    }

    public void Render()
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

    public void Render(Enemy e)
    {
        transform.localScale = new Vector3(e.Size, e.Size, e.Size);

        if (e.Types.Count == 1 || e.TypeAffinities[e.Types[0]] != e.TypeAffinities[e.Types[1]])
        {
            sprtRndr.color = e.Types[0].TypeColor;
        }
        else
        {
            sprtRndr.color = Color.Lerp(e.Types[0].TypeColor, e.Types[1].TypeColor, 0.5f);
        }
    }
}

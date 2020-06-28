using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityData : MonoBehaviour
{
    public Enemy data;
    private EntityMove move;

    private SpriteRenderer sprtRndr;
    private List<GameObject> typeCosmetics;
    private List<GameObject> shopCosmetics;

    public void AssignStats(Enemy enemy)
    {
        sprtRndr = GetComponent<SpriteRenderer>();
        move = GetComponent<EntityMove>();

        data = enemy;
        gameObject.name = data.Name;
        transform.localScale = new Vector2(data.Size, data.Size);
        move.moveSpeedMin = (data.CanMove) ? move.moveSpeedMin : 0f;
        move.moveSpeedMax = (data.CanMove) ? move.moveSpeedMax : 0f;

        if (data.Types.Count == 1 || data.TypeAffinities[data.Types[0]] != data.TypeAffinities[data.Types[1]])
        {
            sprtRndr.color = data.Types[0].TypeColor;
        }
        else
        {
            sprtRndr.color = Color.Lerp(data.Types[0].TypeColor, data.Types[1].TypeColor, 0.5f);
        }
    }
}

using System.Linq;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Attack", menuName = "Combat/Attack")]
public class Attack : CombatAsset
{
    public Types.Collections.Dictionary<int, Types.Miscellaneous.Tuple<Types.Collections.Grid<bool>, Types.Miscellaneous.SaveData, UnityEvent<TileInstance, TileInstance[], Types.Miscellaneous.SaveData>>> effects;

    public void ModifyHealth(TileInstance attacker, TileInstance[] targets, Types.Miscellaneous.SaveData data)
    {
        var damage = data.Get<float>("Damage");

        foreach (TileInstance target in targets.Where(item => item.slime != null))
        {
            float calculatedDamage = attacker.slime.stats.attack * damage / target.slime.stats.defense;
            target.slime.stats.hp -= calculatedDamage;
        }
    }

    public void ApplyEffect(TileInstance attacker, TileInstance[] targets, Types.Miscellaneous.SaveData data)
    {
        var effect = data.Get<TileEffect>("Effect");

        foreach (TileInstance target in targets)
        {
            target.effect = effect;
        }
    }

    public void RearrangeGrid(TileInstance attacker, TileInstance[] targets, Types.Miscellaneous.SaveData data)
    {
        var direction = data.Get<string>("Direction");
    }

    public void ModifyTemporaryStats(TileInstance attacker, TileInstance[] targets, Types.Miscellaneous.SaveData data)
    {
        var length = data.Get<int>("Length");
    }
}

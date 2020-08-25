using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleEntity : MonoBehaviour
{
    protected SpriteRenderer sprtRndr;
    protected BattleManager bm;

    #region Stats

    public string Name;

    public Stats entityStats;
    public float damageBuff = 1f;

    public Dictionary<Type, float> TypeAffinities;
    public List<Type> TopTypes; // Display of types based on highest affinities.

    public List<Move> MyMoves;
    public Ability Ability;

    #endregion

    private void Awake()
    {
        sprtRndr = GetComponent<SpriteRenderer>();
        bm = GameObject.FindGameObjectWithTag("BattleManager").GetComponent<BattleManager>();
    }

    public void Attack(Button button = null)
    {
        BattleEntity target = (this is BattlePlayer) ? (BattleEntity) BattleManager.enemy : BattleManager.player;
        Move attack;

        // Chooses between player and enemy attack types.
        if (this is BattlePlayer)
        {
            attack = button.GetComponent<BattleButton>().assignedMove;

            // If the user uses a move on the enemy that the enemy hasn't seen before, it learns that the opponent has that move.
            if (!(target as BattleEnemy).OpponentsKnownMoves.Contains(attack))
                (target as BattleEnemy).OpponentsKnownMoves.Add(attack);
        }
        else
        {
            attack = (this as BattleEnemy).ChooseMove(target);
        }

        // Exits out of attack if the user doesn't have enough energy.
        if (entityStats.EnergyCurrent < attack.EnergyUse)
        {
            if (this is BattlePlayer)
                (this as BattlePlayer).CoinBonus -= 0.20f;

            bm.Write(Name + " does not have enough energy to use that attack!");
            return;
        }

        if (attack.ExtraEffect == null)
        {
            int totalDamage = CalcDamage(attack, target);
            target.TakeDamage(totalDamage);
            LoseEnergy(attack.EnergyUse);

            bm.Write(Name + " used " + attack.Name + " and did " + totalDamage + " damage!");
        }
        else
        {
            attack.ExtraEffect();
        }

        bm.UpdateStats();
        bm.turnsPassed++;
        BattleManager.SwitchTurns();
    }

    public int CalcDamage(Move attack, BattleEntity target)
    {
        float resNerf = 1f;
        float weakBonus = 1f;
        float RNG = Random.Range(0.8f, 1.0f);
        float bestBonus = (TopTypes.Contains(attack.Type)) ? 1.25f : 1f;
        float bestWeakBonus = 1f;
        float bestResNerf = 1f;
        float immuneNerf = 1f;

        // Calculate weaknesses and resistances.
        // Calculate weakness and resistance bonuses if it's the strongest type.

        int totalDamage;

        if (attack.Type != Types.Typeless)
            totalDamage = (int)((attack.Damage + (entityStats.Pow * 2.5f - target.entityStats.Def * 2.5f)) * (TypeAffinities[attack.Type] * 0.25f + 0.75f) / 5f / resNerf / weakBonus * RNG * bestBonus * bestWeakBonus * bestResNerf * immuneNerf * damageBuff);
        else
            totalDamage = (int)((attack.Damage + (entityStats.Pow * 2.5f - target.entityStats.Def * 2.5f)) / 5f / resNerf / weakBonus * RNG * bestBonus * bestWeakBonus * bestResNerf * immuneNerf * damageBuff);

        // Caps damage if it's greater than the target's HP.
        totalDamage = (totalDamage > target.entityStats.HPCurrent) ? (int)target.entityStats.HPCurrent : totalDamage;

        return (totalDamage > 0) ? totalDamage : 0;
    }

    public void TakeDamage(float dmg)
    {
        entityStats.HPCurrent -= (dmg > entityStats.HPCurrent) ? entityStats.HPCurrent : (uint) dmg;

        if (this is BattlePlayer)
            BattleManager.player.CoinBonus -= dmg / 40f;
        else
            BattleManager.player.CoinBonus += dmg / 40f;
    }

    public void Heal(float amount)
    {
        entityStats.HPCurrent += (amount > entityStats.HPMax - entityStats.HPCurrent) ? entityStats.HPMax - entityStats.HPCurrent : (uint) amount;

        if (this is BattlePlayer)
            BattleManager.player.CoinBonus += amount / 40f;
        else
            BattleManager.player.CoinBonus -= amount / 40f;
    }

    public void LoseEnergy(float energy)
    {
        entityStats.EnergyCurrent -= (energy > entityStats.EnergyCurrent) ? entityStats.EnergyCurrent : (uint) energy;
    }

    public void GainEnergy(float energy)
    {
        entityStats.EnergyCurrent += (energy > entityStats.EnergyMax - entityStats.EnergyCurrent) ? entityStats.EnergyMax - entityStats.EnergyCurrent : (uint) energy;
    }
}

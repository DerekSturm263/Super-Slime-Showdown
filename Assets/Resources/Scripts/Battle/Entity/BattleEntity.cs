using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleEntity : MonoBehaviour
{
    protected SpriteRenderer sprtRndr;
    protected BattleManager bm;

    #region Stats

    public string Name;
    public float HPMax;
    public float HPCurrent;
    public float EnergyMax;
    public float EnergyCurrent;
    public float Pow;
    public float Def;
    public float Spd;

    public Dictionary<Type, float> TypeAffinities;
    public List<Type> TopTypes; // Display of types based on highest affinities.

    public List<Move> Moves;
    public Ability Ability;

    #endregion

    private void Awake()
    {
        sprtRndr = GetComponent<SpriteRenderer>();
        bm = GameObject.FindGameObjectWithTag("BattleManager").GetComponent<BattleManager>();
    }

    public void Attack(Button button = null)
    {
        BattleEntity target = null;
        Move attack;

        // Chooses between player and enemy attack types.
        if (this is BattlePlayer)
            attack = button.GetComponent<BattleButton>().assignedMove;
        else
            attack = Moves[Random.Range(0, Moves.Count)];

        // Exits out of attack if the user doesn't have enough energy.
        if (EnergyCurrent < attack.EnergyUse)
        {
            if (this is BattlePlayer)
                (this as BattlePlayer).CoinBonus -= 0.20f;

            bm.Write(Name + " does not have enough energy to use that attack!");
            return;
        }

        // Chooses the attack target based on the user of the move and what the target type is.
        switch (attack.MoveTarget)
        {
            case Move.Target.Self:
                target = (this is BattlePlayer) ? (BattleEntity) BattleManager.player : BattleManager.enemy;
                break;
            case Move.Target.Opponent:
                target = (this is BattleEnemy) ? (BattleEntity)BattleManager.player : BattleManager.enemy;
                break;
        }

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
            totalDamage = (int) ((attack.Damage + (Pow * 2.5f - target.Def * 2.5f)) * (TypeAffinities[attack.Type] * 0.25f + 0.75f) / 5f / resNerf / weakBonus * RNG * bestBonus * bestWeakBonus * bestResNerf * immuneNerf);
        else
            totalDamage = (int) ((attack.Damage + (Pow * 2.5f - target.Def * 2.5f)) / 5f / resNerf / weakBonus * RNG * bestBonus * bestWeakBonus * bestResNerf * immuneNerf);

        // Caps damage if it's greater than the target's HP.
        totalDamage = (totalDamage > target.HPCurrent) ? (int) target.HPCurrent : totalDamage;

        target.TakeDamage(totalDamage);
        LoseEnergy(attack.EnergyUse);

        bm.Write(Name + " used " + attack.Name + " and did " + totalDamage + " damage!");
        bm.UpdateStats();

        BattleManager.SwitchTurns();
    }

    public void TakeDamage(float dmg)
    {
        HPCurrent -= (dmg > HPCurrent) ? HPCurrent : dmg;

        if (this is BattlePlayer)
            BattleManager.player.CoinBonus -= dmg / 40f;
        else
            BattleManager.player.CoinBonus += dmg / 40f;
    }

    public void Heal(float amount)
    {
        HPCurrent += (amount > HPMax - HPCurrent) ? HPMax - HPCurrent : amount;

        if (this is BattlePlayer)
            BattleManager.player.CoinBonus += amount / 40f;
        else
            BattleManager.player.CoinBonus -= amount / 40f;
    }

    public void LoseEnergy(float energy)
    {
        EnergyCurrent -= (energy > EnergyCurrent) ? EnergyCurrent : energy;
    }

    public void GainEnergy(float energy)
    {
        EnergyCurrent += (energy > EnergyMax - EnergyCurrent) ? EnergyMax - EnergyCurrent : energy;
    }
}

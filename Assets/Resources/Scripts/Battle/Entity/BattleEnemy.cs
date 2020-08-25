using UnityEngine;
using System.Collections.Generic;
using System;
using System.Linq;

public class BattleEnemy : BattleEntity
{
    public List<Move.Function> Priority = new List<Move.Function>();

    public List<Move> OpponentsKnownMoves = new List<Move>();

    public void Setup(Enemy e)
    {
        #region Stats

        Name = e.Name;

        entityStats.HPMax = (uint) (e.enemyStats.HPMax * (e.TimesFought * 1.25f));
        entityStats.HPCurrent = entityStats.HPMax;
        entityStats.EnergyMax = (uint) (e.enemyStats.EnergyMax * (e.TimesFought / 1.5f));
        entityStats.EnergyCurrent = entityStats.EnergyMax;
        entityStats.Pow = e.enemyStats.Pow * e.TimesFought;
        entityStats.Def = e.enemyStats.Def * e.TimesFought * 1.5f;
        entityStats.Spd = e.enemyStats.Spd * e.TimesFought * 1.5f;

        TopTypes = e.Types;
        TypeAffinities = e.TypeAffinities;

        foreach (Type type in e.TypeAffinities.Keys.ToList())
        {
            TypeAffinities[type] *= (e.TimesFought * 6 - 4);
            Debug.Log(TypeAffinities[type]);
        }

        switch (e.TimesFought)
        {
            case 1:
                MyMoves = e.Level1Moves;
                break;
            case 2:
                MyMoves = e.Level2Moves;
                break;
            case 3:
                MyMoves = e.Level3Moves;
                break;
            case 4:
                MyMoves = e.Level4Moves;
                break;
            default:
                MyMoves = e.Level5Moves;
                break;
        }

        if (e.TimesFought >= e.AbilityThreshold)
            Ability = e.Ability;
        else
            Ability = null;

        #endregion

        #region Display

        transform.localScale = new Vector3(e.Size, e.Size, e.Size);

        if (e.Types.Count == 1 || e.TypeAffinities[e.Types[0]] != e.TypeAffinities[e.Types[1]])
        {
            sprtRndr.color = e.Types[0].TypeColor;
        }
        else
        {
            sprtRndr.color = Color.Lerp(e.Types[0].TypeColor, e.Types[1].TypeColor, 0.5f);
        }

        #endregion
    }

    public Move ChooseMove(BattleEntity target)
    {
        // A list of the opponent's known moves sorted by damage.
        List<Move> sortedMoves = OpponentsKnownMoves;
        if (!sortedMoves.Contains(Moves.Roll))
        {
            sortedMoves.Add(Moves.Roll);
        }
        sortedMoves.Sort((x, y) => target.CalcDamage(y, this).CompareTo(target.CalcDamage(x, this)));

        Priority.Clear();

        Move wantedMove = null;

        // Adds blocking and healing to the priority list.
        if (entityStats.HPCurrent <= target.CalcDamage(sortedMoves[0], this) && target.entityStats.EnergyCurrent >= sortedMoves[0].EnergyUse)
        {
            Priority.Add(Move.Function.Heal);
            Priority.Add(Move.Function.Block);

            Debug.Log("I should heal or block.");
        }

        // There are no buffing moves at the moment.
        /*if ()
        {

        }*/

        // There are no status moves at the moment.
        /*if ()
        {

        }*/

        // Creates a list of all the strongest moves that deal damage specifically.
        List<Move> strongestMoves = MyMoves;
        strongestMoves.Sort((x, y) => CalcDamage(y, target).CompareTo(CalcDamage(x, target)));
        strongestMoves.ForEach(x => Debug.Log(x.Name + ": " + CalcDamage(x, target)));

        // Decides to either use a cheap attack or restore energy.
        if (entityStats.EnergyCurrent >= strongestMoves[0].EnergyUse)
        {
            // Tries to use strongest move.
            wantedMove = strongestMoves[0];

            Debug.Log("I should attack strong.");
        }
        else
        {
            if (target.CalcDamage(strongestMoves[1], this) >= target.entityStats.HPCurrent)
            {
                // Tries to use second strongest move.
                wantedMove = strongestMoves[1];

                Debug.Log("I should attack weak.");
            }
            else
            {
                // Tries to restore energy.
                Priority.Add(Move.Function.Restore_Energy);

                Debug.Log("I should restore energy.");
            }
        }

        Priority.Add(Move.Function.Attack);

        // Goes through each of the slime's priorities and sees if it can find a move to use that works well.
        foreach (Move.Function t in Priority)
        {
            foreach (Move m in strongestMoves)
            {
                if (m.MoveFunction == t && entityStats.EnergyCurrent >= m.EnergyUse)
                {
                    return m;
                }
            }
        }

        // Shouldn't ever run.
        return null;
    }
}

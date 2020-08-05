using UnityEngine;
using System.Collections.Generic;

public class BattleEnemy : BattleEntity
{
    public void Setup(Enemy e)
    {
        #region Stats

        Name = e.Name;

        entityStats.HPMax = e.enemyStats.HPMax * e.TimesFought;
        entityStats.HPCurrent = entityStats.HPMax;
        entityStats.EnergyMax = (uint) (e.enemyStats.EnergyMax * (e.TimesFought / 2f));
        entityStats.EnergyCurrent = entityStats.EnergyMax;
        entityStats.Pow = e.enemyStats.Pow * e.TimesFought;
        entityStats.Def = e.enemyStats.Def * e.TimesFought;
        entityStats.Spd = e.enemyStats.Spd * e.TimesFought;

        TopTypes = e.Types;
        TypeAffinities = e.TypeAffinities;

        switch (e.TimesFought)
        {
            case 1:
                Moves = e.Level1Moves;
                break;
            case 2:
                Moves = e.Level2Moves;
                break;
            case 3:
                Moves = e.Level3Moves;
                break;
            case 4:
                Moves = e.Level4Moves;
                break;
            default:
                Moves = e.Level5Moves;
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
}

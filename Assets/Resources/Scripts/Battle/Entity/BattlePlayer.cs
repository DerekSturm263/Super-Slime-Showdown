using UnityEngine;
using System.Linq;

public class BattlePlayer : BattleEntity
{
    public float CoinBonus;

    public void Setup()
    {
        #region Stats

        Name = PlayerInfo.playerName;

        entityStats.HPMax = PlayerInfo.playerStats.HPMax;
        entityStats.HPCurrent = PlayerInfo.playerStats.HPCurrent;
        entityStats.EnergyMax = PlayerInfo.playerStats.EnergyMax;
        entityStats.EnergyCurrent = PlayerInfo.playerStats.EnergyCurrent;
        entityStats.Pow = PlayerInfo.playerStats.Pow;
        entityStats.Def = PlayerInfo.playerStats.Def;
        entityStats.Spd = PlayerInfo.playerStats.Spd;

        TopTypes = PlayerInfo.types;
        TypeAffinities = PlayerInfo.typeAffinities;

        MyMoves = PlayerInfo.activeMoves;
        Ability = PlayerInfo.activeAbility;

        CoinBonus = 1f;

        #endregion

        #region Display

        PlayerInfo.types.Clear();

        var typesList = TypeAffinities.ToList();
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

        #endregion
    }
}

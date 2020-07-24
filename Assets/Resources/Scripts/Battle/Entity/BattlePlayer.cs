using UnityEngine;
using System.Linq;

public class BattlePlayer : BattleEntity
{
    public float CoinBonus;

    public void Setup()
    {
        #region Stats

        Name = PlayerInfo.playerName;
        HPMax = PlayerInfo.HPMax;
        HPCurrent = PlayerInfo.HPCurrent;
        EnergyMax = PlayerInfo.EnergyMax;
        EnergyCurrent = PlayerInfo.EnergyCurrent;
        Pow = PlayerInfo.Pow;
        Def = PlayerInfo.Def;
        Spd = PlayerInfo.Spd;

        TopTypes = PlayerInfo.types;
        TypeAffinities = PlayerInfo.typeAffinities;

        Moves = PlayerInfo.activeMoves;
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

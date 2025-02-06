using System;
using System.Collections.Generic;

[Serializable]
public struct CombatData
{
    public Types.Collections.Dictionary<Type, float> elementProficiencies;

    public List<Attack> attacks;
    public Ability ability;
}

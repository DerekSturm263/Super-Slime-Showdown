using UnityEngine;

[CreateAssetMenu(fileName = "Element Unlock Map", menuName = "Combat/Element Unlock Map")]
public class ElementUnlockMap : ScriptableObject
{
    public Types.Collections.Dictionary<int, CombatAsset> levelsToUnlocks;
}

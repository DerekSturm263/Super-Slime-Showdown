using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonType : MonoBehaviour
{
    private enum TypeEnum
    {
        Nature, Fire, Water, Ice, Earth, Volt, Toxin, Wind, Light, Shadow
    }
    [SerializeField] private TypeEnum slimeType = TypeEnum.Nature;

    public Type buttonType;

    private void Awake()
    {
        switch (slimeType)
        {
            case TypeEnum.Nature:
                buttonType = Types.Nature;
                break;
            case TypeEnum.Water:
                buttonType = Types.Water;
                break;
            case TypeEnum.Fire:
                buttonType = Types.Fire;
                break;
            case TypeEnum.Ice:
                buttonType = Types.Ice;
                break;
            case TypeEnum.Earth:
                buttonType = Types.Earth;
                break;
            case TypeEnum.Volt:
                buttonType = Types.Volt;
                break;
            case TypeEnum.Toxin:
                buttonType = Types.Toxin;
                break;
            case TypeEnum.Wind:
                buttonType = Types.Wind;
                break;
            case TypeEnum.Light:
                buttonType = Types.Light;
                break;
            case TypeEnum.Shadow:
                buttonType = Types.Shadow;
                break;
        }
    }
}

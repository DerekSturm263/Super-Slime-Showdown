using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class OverworldUIManager : MonoBehaviour
{
    public enum Menu
    {
        None, Pause, Stats, Tent, Shop, Cooking_Pot, Online
    }
    public static Menu openUI;

    public GameObject pauseMenu;
    public GameObject statsMenu;
    public GameObject tentMenu;
    public GameObject shopMenu;
    public GameObject cookingPotMenu;
    public GameObject onlineMenu;

    [Header("Stats")]
    public TMPro.TMP_Text hpMax;
    public TMPro.TMP_Text hpCurrent;
    public TMPro.TMP_Text energyMax;
    public TMPro.TMP_Text energyCurrent;
    public TMPro.TMP_Text pow;
    public TMPro.TMP_Text def;
    public TMPro.TMP_Text spd;

    public void UpdateStats()
    {
        hpMax.text = PlayerInfo.HPMax.ToString();
        hpCurrent.text = PlayerInfo.HPCurrent.ToString();
        energyMax.text = PlayerInfo.EnergyMax.ToString();
        energyCurrent.text = PlayerInfo.EnergyCurrent.ToString();
        pow.text = PlayerInfo.Pow.ToString();
        def.text = PlayerInfo.Def.ToString();
        spd.text = PlayerInfo.Spd.ToString();
    }

    public void OnClose()
    {
        switch (openUI)
        {
            case Menu.Pause:
                pauseMenu.SetActive(false);
                break;
            case Menu.Stats:
                statsMenu.SetActive(false);
                break;
            case Menu.Tent:
                tentMenu.SetActive(false);
                break;
            case Menu.Shop:
                shopMenu.SetActive(false);
                break;
            case Menu.Cooking_Pot:
                cookingPotMenu.SetActive(false);
                break;
            case Menu.Online:
                onlineMenu.SetActive(false);
                break;
        }
    }

    public void OnOpenPause()
    {
        if (openUI != Menu.None)
            return;

        openUI = Menu.Pause;
    }
    public void OnOpenStats()
    {
        if (openUI != Menu.None)
            return;

        openUI = Menu.Stats;
        statsMenu.SetActive(true);
        UpdateStats();
    }

    public static void OpenTent()
    {
        if (openUI != Menu.None)
            return;

        openUI = Menu.Tent;
    }

    public static void OpenShop()
    {
        if (openUI != Menu.None)
            return;

        openUI = Menu.Shop;
    }

    public static void OpenCookingPot()
    {
        if (openUI != Menu.None)
            return;

        openUI = Menu.Cooking_Pot;
    }

    public static void OpenOnline()
    {
        if (openUI != Menu.None)
            return;

        openUI = Menu.Online;
    }
}

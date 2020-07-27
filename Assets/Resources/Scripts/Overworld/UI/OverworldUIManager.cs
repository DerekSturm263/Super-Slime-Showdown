using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class OverworldUIManager : MonoBehaviour
{
    public enum Menu
    {
        None, Pause, Stats, Tent, Shop, Cooking_Pot, Online
    }
    public static Menu openUI = Menu.None;

    public Animator buttonOverlays;

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

    [Header("Items")]
    public TMPro.TMP_Text goldCurrent;

    public void UpdateStats()
    {
        hpMax.text = "/" + PlayerInfo.HPMax.ToString();
        hpCurrent.text = PlayerInfo.HPCurrent.ToString();
        energyMax.text = "/" + PlayerInfo.EnergyMax.ToString();
        energyCurrent.text = PlayerInfo.EnergyCurrent.ToString();
        pow.text = PlayerInfo.Pow.ToString();
        def.text = PlayerInfo.Def.ToString();
        spd.text = PlayerInfo.Spd.ToString();
    }

    public void UpdateItems()
    {
        goldCurrent.text = "x" + PlayerInfo.goldCount.ToString();
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

        buttonOverlays.SetBool("Enter", true);
        buttonOverlays.SetBool("Exit", false);
        openUI = Menu.None;
    }

    public void OnOpenPause()
    {
        if (openUI != Menu.None)
            return;

        openUI = Menu.Pause;
        pauseMenu.SetActive(true);
        buttonOverlays.SetBool("Exit", true);
        buttonOverlays.SetBool("Enter", false);
    }

    public void OnOpenStats()
    {
        if (openUI != Menu.None)
            return;

        openUI = Menu.Stats;
        statsMenu.SetActive(true);
        buttonOverlays.SetBool("Exit", true);
        buttonOverlays.SetBool("Enter", false);
        UpdateStats();
    }

    public void OpenTent()
    {
        if (openUI != Menu.None)
            return;

        openUI = Menu.Tent;
        tentMenu.SetActive(true);
        buttonOverlays.SetBool("Exit", true);
        buttonOverlays.SetBool("Enter", false);
    }

    public void OpenShop()
    {
        if (openUI != Menu.None)
            return;

        openUI = Menu.Shop;
        shopMenu.SetActive(true);
        buttonOverlays.SetBool("Exit", true);
        buttonOverlays.SetBool("Enter", false);
    }

    public void OpenCookingPot()
    {
        if (openUI != Menu.None)
            return;

        openUI = Menu.Cooking_Pot;
        cookingPotMenu.SetActive(true);
        buttonOverlays.SetBool("Exit", true);
        buttonOverlays.SetBool("Enter", false);
    }

    public void OpenOnline()
    {
        if (openUI != Menu.None)
            return;

        openUI = Menu.Online;
        onlineMenu.SetActive(true);
        buttonOverlays.SetBool("Exit", true);
        buttonOverlays.SetBool("Enter", false);
    }
}

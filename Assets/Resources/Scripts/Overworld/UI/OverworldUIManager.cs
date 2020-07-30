using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class OverworldUIManager : MonoBehaviour
{
    public static GameObject currentMenu = null;
    public static GameObject currentTab = null;

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
    public TMPro.TMP_Text types;

    [Header("Items")]
    public TMPro.TMP_Text goldCurrent;

    [Header("Tent")]
    public TMPro.TMP_Text tentHPMax;
    public TMPro.TMP_Text tentHPCurrent;
    public TMPro.TMP_Text tentEnergyMax;
    public TMPro.TMP_Text tentEnergyCurrent;

    private void Awake()
    {
        currentMenu = null;
    }

    public void OnClose()
    {
        CloseMenu(currentMenu);

        buttonOverlays.SetBool("Enter", true);
        buttonOverlays.SetBool("Exit", false);
    }

    public void OpenMenu(GameObject menu)
    {
        if (currentMenu != null)
            return;

        menu.SetActive(true);
        currentMenu = menu;

        if (menu == statsMenu)
        {
            UpdateStatsPage();
            SwitchTab(statsMenu.transform.GetChild(3).gameObject);
        }
        else if (menu == tentMenu)
        {
            UpdateTentPage();
        }

        ResetButtons();
    }

    public void CloseMenu(GameObject menu)
    {
        if (menu.GetComponent<Animator>() != null)
            menu.GetComponent<Animator>().SetBool("Exit", true);
        else
            menu.SetActive(false);

        currentMenu = null;
    }

    public void SwitchTab(GameObject newTab)
    {
        if (newTab == currentTab)
            return;

        if (currentTab != null)
            currentTab.SetActive(false);
        newTab.SetActive(true);
        currentTab = newTab;
    }

    private void ResetButtons()
    {
        buttonOverlays.SetBool("Exit", true);
        buttonOverlays.SetBool("Enter", false);
    }

    public void UpdateStatsPage()
    {
        // Stats.
        hpMax.text = "/" + PlayerInfo.HPMax.ToString();
        hpCurrent.text = PlayerInfo.HPCurrent.ToString();
        energyMax.text = "/" + PlayerInfo.EnergyMax.ToString();
        energyCurrent.text = PlayerInfo.EnergyCurrent.ToString();
        pow.text = PlayerInfo.Pow.ToString();
        def.text = PlayerInfo.Def.ToString();
        spd.text = PlayerInfo.Spd.ToString();
        types.text = "";
        PlayerInfo.types.ForEach(x => types.text += x.Name);

        // Inventory.
        goldCurrent.text = "x" + PlayerInfo.goldCount.ToString();
    }

    public void UpdateTentPage()
    {
        tentHPMax.text = "/" + PlayerInfo.HPMax.ToString();
        tentHPCurrent.text = PlayerInfo.HPCurrent.ToString();
        tentEnergyMax.text = "/" + PlayerInfo.EnergyMax.ToString();
        tentEnergyCurrent.text = PlayerInfo.EnergyCurrent.ToString();
    }

    public void Heal()
    {
        if (PlayerInfo.goldCount < 100)
            return;

        PlayerInfo.HPCurrent = PlayerInfo.HPMax;
        PlayerInfo.EnergyCurrent = PlayerInfo.EnergyMax;

        PlayerInfo.goldCount -= 100;

        UpdateTentPage();
    }
}

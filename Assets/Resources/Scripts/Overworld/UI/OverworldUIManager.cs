using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

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
    public GameObject itemLayout;

    [Header("Cooking Pot")]
    public GameObject cookingItemLayout;

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
        else if (menu == cookingPotMenu)
        {
            UpdateCookingPage();
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
        hpMax.text = "/" + PlayerInfo.playerStats.HPMax.ToString();
        hpCurrent.text = PlayerInfo.playerStats.HPCurrent.ToString();
        energyMax.text = "/" + PlayerInfo.playerStats.EnergyMax.ToString();
        energyCurrent.text = PlayerInfo.playerStats.EnergyCurrent.ToString();
        pow.text = PlayerInfo.playerStats.Pow.ToString();
        def.text = PlayerInfo.playerStats.Def.ToString();
        spd.text = PlayerInfo.playerStats.Spd.ToString();
        types.text = "";
        PlayerInfo.types.ForEach(x => types.text += x.Name);

        // Inventory.
        goldCurrent.text = "x" + PlayerInfo.goldCount.ToString();

        //itemLayout.GetComponentsInChildren<Transform>().ToList().ForEach(x =>
        //{
        //    if (itemLayout.name.Equals("Content"))
        //        Destroy(x);
        //});
        PlayerInfo.inventory.ForEach(x =>
        {
            GameObject newItem = new GameObject(x.ItemName);
            Image icon = newItem.AddComponent<Image>();

            newItem.transform.SetParent(itemLayout.transform);
            newItem.GetComponent<RectTransform>().localScale = new Vector3(1f, 1f, 1f);
            icon.sprite = x.Icon;
        });
    }

    public void UpdateTentPage()
    {
        tentHPMax.text = "/" + PlayerInfo.playerStats.HPMax.ToString();
        tentHPCurrent.text = PlayerInfo.playerStats.HPCurrent.ToString();
        tentEnergyMax.text = "/" + PlayerInfo.playerStats.EnergyMax.ToString();
        tentEnergyCurrent.text = PlayerInfo.playerStats.EnergyCurrent.ToString();
    }

    public void UpdateCookingPage()
    {
        cookingItemLayout.GetComponentsInChildren<Transform>().ToList().ForEach((x) => Destroy(x));
        PlayerInfo.inventory.ForEach(x =>
        {
            GameObject newItem = new GameObject(x.ItemName);
            Image icon = newItem.AddComponent<Image>();

            newItem.transform.SetParent(cookingItemLayout.transform);
            newItem.GetComponent<RectTransform>().localScale = new Vector3(1f, 1f, 1f);
            icon.sprite = x.Icon;
        });
    }

    public void Heal()
    {
        if (PlayerInfo.goldCount < 100)
            return;

        PlayerInfo.playerStats.HPCurrent = PlayerInfo.playerStats.HPMax;
        PlayerInfo.playerStats.EnergyCurrent = PlayerInfo.playerStats.EnergyMax;

        PlayerInfo.goldCount -= 100;

        UpdateTentPage();
    }
}

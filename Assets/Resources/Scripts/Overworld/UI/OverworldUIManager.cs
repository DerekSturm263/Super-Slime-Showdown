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

    public Image darkenedBG;

    public void CloseMenu()
    {
        StartCoroutine(Close());
    }

    private IEnumerator Close()
    {
        yield return new WaitForSeconds(0.5f);
        openUI = Menu.None;
    }

    public void OpenPause()
    {
        if (openUI != Menu.None)
            return;

        openUI = Menu.Pause;
    }
    public void OpenStats()
    {
        if (openUI != Menu.None)
            return;

        openUI = Menu.Stats;
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

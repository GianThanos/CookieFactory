using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public int savedCookies;
    public int savedCash;
    public int savedBakers;
    public int savedShops;
    public int savedValue;
    public int savedBakersps;
    public int savedShopsps;
    public int savedShopsValue;
    public int savedBakersValue;
    public GameObject CreatingCookie;
    public GameObject SellingCookie;




    void Start()
    {


        if (MainMenuOptions.isLoading == true)
        {



            savedCookies = PlayerPrefs.GetInt("SavedCookies");
            GlobalCookies.CookieCount = savedCookies;

            savedCash = PlayerPrefs.GetInt("SavedCash");
            GlobalCash.CashCount = savedCash;

            savedBakers = PlayerPrefs.GetInt("SavedBakers");
            GlobalBaker.numberOfBakers = savedBakers;

            savedBakersps = PlayerPrefs.GetInt("SavedBakersps");
            GlobalBaker.bakePerSec = savedBakersps;

            savedShops = PlayerPrefs.GetInt("SavedShops");
            GlobalShop.numberOfShops = savedShops;

            savedShopsps = PlayerPrefs.GetInt("SavedShopsps");
            GlobalShop.shopPerSec = savedShopsps;

            savedValue = PlayerPrefs.GetInt("SaveValue");
            SaveGame.saveValue = savedValue;

            savedShopsValue = PlayerPrefs.GetInt("SavedShopsValue");
            GlobalShop.shopValue = savedShopsValue;

            savedBakersValue = PlayerPrefs.GetInt("SavedBakersValue");
            GlobalBaker.bakerValue = savedBakersValue;


            if (savedBakers != 0)
            {
                CreatingCookie.SetActive(true);
            }
            if (savedShops != 0)
            {
                SellingCookie.SetActive(true);
            }

        }
    }

}

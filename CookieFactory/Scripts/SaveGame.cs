using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{
    public int saveGameCash;
    public static int saveValue = 10;
    public GameObject saveButton;
    public GameObject saveText;

    
    void Update()
    {
        saveText.GetComponent<Text>().text = "Cost: £" + saveValue;
        saveGameCash = GlobalCash.CashCount;
        if (saveGameCash >= saveValue)
        {
            saveButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            saveButton.GetComponent<Button>().interactable = false;
        }
    
    
    }

    public void SaveTheGame()
    {
        GlobalCash.CashCount -= saveValue;
        PlayerPrefs.SetInt("SavedCookies", GlobalCookies.CookieCount);
        PlayerPrefs.SetInt("SavedCash", GlobalCash.CashCount);
        PlayerPrefs.SetInt("SavedBakersps", GlobalBaker.bakePerSec);
        PlayerPrefs.SetInt("SavedShops", GlobalShop.numberOfShops);
        PlayerPrefs.SetInt("SavedBakers", GlobalBaker.numberOfBakers);
        PlayerPrefs.SetInt("SavedShopsps", GlobalShop.shopPerSec);
        PlayerPrefs.SetInt("SavedShopsValue", GlobalShop.shopValue);
        PlayerPrefs.SetInt("SavedBakersValue", GlobalBaker.bakerValue);

        saveValue *= 2;
        PlayerPrefs.SetInt("SaveValue", saveValue);
        
    }
}

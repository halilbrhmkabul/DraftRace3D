using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_GameData : MonoBehaviour
{

    public static scr_GameData Instance;

    public bool GameActive;


    public int Money;
    public int Level;
    public int InGameMoney;



    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(Instance);
        }
    }

    private void Start()
    {
        GetGameDatas();
    }

    void GetGameDatas()
    {
        Money = PlayerPrefs.GetInt("money");
        Level = PlayerPrefs.GetInt("level");

        scr_UiManager.Instance.LoadUI(Money,Level);
    }
    

    public void InGameMoneyAdd(int addedCoin)
    {
        Money += addedCoin;

        PlayerPrefs.SetInt("money",Money);

        scr_UiManager.Instance.InGameMoneyAdd(Money);    
    }

    public void SetLevel()
    {
        Level++;
        PlayerPrefs.SetInt("level",Level--);
    }



}

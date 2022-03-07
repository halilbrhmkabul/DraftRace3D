using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class scr_UiManager : MonoBehaviour
{
    public static scr_UiManager Instance;

    [SerializeField] GameObject panelEndGame;
    [SerializeField] GameObject panelStartGame;

    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] TextMeshProUGUI levelText;




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

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void LoadUI(int money, int level)
    {
        moneyText.text = money.ToString() + "$";
        levelText.text=  "Level " + level.ToString();
    }

    public void InGameMoneyAdd(int money)
    {
        moneyText.text = money.ToString() + "$";
    }

    public void PanelEndGameOpen()
    {
        panelEndGame.SetActive(true);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(0);
    }

    public void StartButton()
    {
        scr_GameData.Instance.GameActive = true;
        panelStartGame.SetActive(false);
        scr_PlayerController.Instance.GameStart();
    }
}

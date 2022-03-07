using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Finish : MonoBehaviour
{
    [SerializeField] GameObject particleConfetti;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Win");

            particleConfetti.SetActive(true);
            scr_GameData.Instance.SetLevel();
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Finish");

            scr_PlayerController.Instance.splineFollowerScript.followSpeed = 0;

            scr_GameData.Instance.SetLevel();


            scr_UiManager.Instance.PanelEndGameOpen();  
        }
    }
}

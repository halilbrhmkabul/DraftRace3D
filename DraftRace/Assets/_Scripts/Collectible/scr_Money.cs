using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class scr_Money : MonoBehaviour
{


    //1. y�ntem
    [SerializeField] ParticleSystem moneyParticle;
    [SerializeField] GameObject moneyObj;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            moneyParticle.Play();    //1. y�ntem

            scr_GameData.Instance.InGameMoneyAdd(10);

            moneyObj.SetActive(false);

            //StartCoroutine(waitForClose());
        }
    }


    //IEnumerator waitForClose()
    //{
    //    yield return new WaitForSeconds(1f);
        
    //}
}

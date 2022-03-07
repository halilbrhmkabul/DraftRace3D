using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Barricade : MonoBehaviour
{
     [SerializeField] GameObject coneObj;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scr_PlayerController.Instance.splineDropSpeed();

            coneObj.SetActive(false);

            //StartCoroutine(waitForClose());
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scr_LeftDoor : MonoBehaviour
{
    [SerializeField] scr_Gate gateScript;

    [SerializeField] int leftDoorInt;
    int _mathOperatorInt;
    [SerializeField] TextMeshPro leftDoorText;
    int randomNumbers;

    bool isTriggered=false;









    //[SerializeField] GameObject redOBJ;
    //[SerializeField] GameObject greenOBJ;







    public enum MathSelect
    {
        Topla,
        Cikar,
        Carp,
        Bol
    }

    public MathSelect MathSelectEnumLeft;

  

    private void Start()
    {
        if (MathSelectEnumLeft == MathSelect.Topla)
        {
            leftDoorText.text = "+";
            leftDoorText.text += leftDoorInt;
            _mathOperatorInt = 0;
        }

        else if (MathSelectEnumLeft == MathSelect.Cikar)
        {
            leftDoorText.text = "-";
            leftDoorText.text += leftDoorInt;
            _mathOperatorInt = 1;
        }
        else if (MathSelectEnumLeft == MathSelect.Carp)
        {
            leftDoorText.text = "x";
            leftDoorText.text += leftDoorInt;
            _mathOperatorInt = 2;
        }
        else if (MathSelectEnumLeft == MathSelect.Bol)
        {
            leftDoorText.text = "÷";
            leftDoorText.text += leftDoorInt;
            _mathOperatorInt = 3;
        }






        //int randomGreenRed = Random.Range(0,2);

        //if (randomGreenRed==0)
        //{
        //    //yeşil kapı

        //    greenOBJ.SetActive(true);
        //    redOBJ.SetActive(false);
        //}
        //else
        //{
        //    //kirmizi kapi

        //    redOBJ.SetActive(true);
        //    greenOBJ.SetActive(false);

        //}







    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && isTriggered==false)
        {
            isTriggered = true;
            gateScript.LeftDoorTriggered(leftDoorInt,_mathOperatorInt);
        }
    }
}

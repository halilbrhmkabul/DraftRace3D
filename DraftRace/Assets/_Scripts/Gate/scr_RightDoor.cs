using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scr_RightDoor : MonoBehaviour
{
    [SerializeField] scr_Gate gateScript2;
    [SerializeField] int rightDoorInt;
    int _mathOperatorInt;
    [SerializeField] TextMeshPro rightDoorText;

    public MathSelect MathSelectEnumRight;

    bool isTriggered = false;

    public enum MathSelect
    {
        Topla,
        Cikar,
        Carp,
        Bol
    }

       

    void Start()
    {
        if(MathSelectEnumRight == MathSelect.Topla)
        {
            rightDoorText.text = "+";
            rightDoorText.text += rightDoorInt;
            _mathOperatorInt=0;
        }
        

        else if(MathSelectEnumRight == MathSelect.Cikar)
        {
            rightDoorText.text = "-";
            rightDoorText.text += rightDoorInt;
            _mathOperatorInt = 1;
        }

        else if(MathSelectEnumRight == MathSelect.Carp)
        {
            rightDoorText.text = "x";
            rightDoorText.text += rightDoorInt;
            _mathOperatorInt = 2;
        }

        else if(MathSelectEnumRight == MathSelect.Bol)
        {
            rightDoorText.text = "÷";
            rightDoorText.text += rightDoorInt;
            _mathOperatorInt = 3;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && isTriggered == false)
        {
            isTriggered = true;
            gateScript2.RightDoorTriggered(rightDoorInt,_mathOperatorInt);
        }
    }

    void Update()
    {
        
    }
}

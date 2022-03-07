using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class scr_Gate : MonoBehaviour
{

    void Start()
    {



    }


    public void LeftDoorTriggered(int number, int mathSelect) // 0-Topla, 1-Cikar, 2-Carp, 3-Bol
    {
        switch (mathSelect)
        {
            case 0:
                scr_PlayerController.Instance.SplineFollowerSpeedSet(number,mathSelect);
                break;

            case 1:
                scr_PlayerController.Instance.SplineFollowerSpeedSet(number , mathSelect);
                break;
            case 2:
                scr_PlayerController.Instance.SplineFollowerSpeedSet(number, mathSelect);
                break;
            case 3:
                scr_PlayerController.Instance.SplineFollowerSpeedSet(number, mathSelect);
                break;

            default:
                break;
        }
    }    
    
    public void RightDoorTriggered(int number, int mathSelect)
    {
        switch (mathSelect)
        {
            case 0:
                scr_PlayerController.Instance.SplineFollowerSpeedSet(number, mathSelect);
                break;

            case 1:
                scr_PlayerController.Instance.SplineFollowerSpeedSet(number, mathSelect);
                break;
            case 2:
                scr_PlayerController.Instance.SplineFollowerSpeedSet(number, mathSelect);
                break;
            case 3:
                scr_PlayerController.Instance.SplineFollowerSpeedSet(number, mathSelect);
                break;

            default:
                break;
        }
    }


}

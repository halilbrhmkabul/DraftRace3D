using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnWheels : MonoBehaviour
{
    public static TurnWheels Instance;   //6556565656


    public Transform leftWheel, rightWheel;
    [SerializeField] float steerAngle;


    void Awake() //565656565
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



    public void RotateTire(float variableRotation)
    {
        leftWheel.localRotation = Quaternion.Slerp(leftWheel.localRotation, Quaternion.Euler(0, variableRotation, 0), .1f);
        rightWheel.localRotation = Quaternion.Slerp(rightWheel.localRotation, Quaternion.Euler(0, variableRotation, 0), .1f);
    }
   
}

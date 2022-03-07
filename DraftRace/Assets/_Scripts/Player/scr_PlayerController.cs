using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Dreamteck.Splines;
using TMPro;

public class scr_PlayerController : MonoBehaviour
{
    public static scr_PlayerController Instance;

    public SplineFollower splineFollowerScript;
    [SerializeField] TextMeshPro splineFollowSpeedText;
    [SerializeField] int playerCarIndexOld;
    [SerializeField] int playerCarIndexNew;


    [SerializeField] int startSpeed;



    void Awake()
    {
        if (Instance==null)
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
        SplineFollowerSpeedTextSet();
    }
   

    public void SplineFollowerSpeedSet(float variableSpeed,int mathOperator)
    {
       
        switch (mathOperator)
        {
            case 0:
                splineFollowerScript.followSpeed += variableSpeed*.1f;
                SplineFollowerSpeedTextSet();
                break;

            case 1:
                splineFollowerScript.followSpeed -= variableSpeed*.1f;
                SplineFollowerSpeedTextSet();
                break;
            case 2:
                splineFollowerScript.followSpeed *= variableSpeed;
                SplineFollowerSpeedTextSet();
                break;
            case 3:
                splineFollowerScript.followSpeed /= variableSpeed;
                SplineFollowerSpeedTextSet();
                break;

            default:
                break;
        }


        playerCarIndexNew = (((int)(splineFollowerScript.followSpeed * 10f)) / 100);
        scr_TransformCar.Instance.CarTransformChange(playerCarIndexOld,playerCarIndexNew);
        playerCarIndexOld = playerCarIndexNew;
        
    }

    void SplineFollowerSpeedTextSet()
    {
        splineFollowSpeedText.text = (int)(splineFollowerScript.followSpeed * 10) + " km/h";
    }

     

    public void GameStart()
    {
        splineFollowerScript.followSpeed = startSpeed;
        SplineFollowerSpeedTextSet();
    }

    public void splineDropSpeed()
    {
        splineFollowerScript.followSpeed-=0.1f;
        SplineFollowerSpeedTextSet();
    }



}

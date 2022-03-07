using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_PlayerChildController : MonoBehaviour
{
    float _touchOldPosX, _touchNewPosX, _deltaX;
    float _touchRotY;

    [SerializeField] float horizontalSpeed;
    [SerializeField] float rotationSpeed;
    [SerializeField] float clampX;
    



    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _touchNewPosX += Input.GetAxis("Mouse X") * horizontalSpeed * Time.deltaTime;
            _deltaX = _touchNewPosX - _touchOldPosX;
            _touchOldPosX = _touchNewPosX;

            transform.localPosition = new Vector3(transform.localPosition.x+_deltaX, transform.localPosition.y, transform.localPosition.z);

            
          
            
        }

        if (Input.GetMouseButtonUp(0))
        {
            _deltaX = 0;
                        
        }

        

        transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(0, _deltaX * rotationSpeed, 0), .1f);
        transform.localPosition = new Vector3(Mathf.Clamp(transform.localPosition.x, -clampX, clampX)
            ,transform.localPosition.y
            ,transform.localPosition.z);

        TurnWheels.Instance.RotateTire(_deltaX*500);

    }
}

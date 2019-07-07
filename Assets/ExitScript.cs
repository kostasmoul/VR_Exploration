using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour {

    public Transform  cameraTransform;
    
   //distance from camera
     public float distanceFromCamera;

    void Update()
    {
        Vector3 resultingPosition = cameraTransform.position + cameraTransform.forward * distanceFromCamera;
        // transform.position = new Vector3(resultingPosition.x, transform.position.y, resultingPosition.z);
        transform.SetPositionAndRotation(new Vector3(resultingPosition.x, transform.position.y, resultingPosition.z), cameraTransform.rotation);
        //transform.SetPositionAndRotation(new Vector3(resultingPosition.x, transform.position.y, resultingPosition.z), Quaternion.Euler(-90.0f, cameraTransform.eulerAngles.y, cameraTransform.eulerAngles.y) );
        

    }

    public void ExitApp()
    {
        Application.Quit();
    }
}

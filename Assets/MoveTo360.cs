using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo360 : MonoBehaviour {
    public GameObject player;
    private CharacterController cc;
    private Vector3 targetPosition;
    private Quaternion targetRotation;

    public void MoveToSphere()
    {
        Debug.Log("IIN");
        cc = player.GetComponent<CharacterController>();
        player.GetComponent<LookWalk>().enabled = false;
        targetPosition = this.transform.position;
        targetRotation = this.transform.rotation;

        //Debug.Log(targetPosition);
        this.GetComponent<SphereCollider>().enabled = false;
        cc.transform.SetPositionAndRotation(targetPosition, targetRotation);
  



    }
    public void ExitSphere()
    {
        
        player.GetComponent<LookWalk>().enabled = true;
       
        Invoke("reEnableCollider", 3);



    }

    private void reEnableCollider()
    {
        this.GetComponent<SphereCollider>().enabled = true;
    }
}

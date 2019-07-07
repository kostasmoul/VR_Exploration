using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour {
    public GameObject player;
    private CharacterController cc;
    private Vector3 targetPosition;
    private Quaternion targetRotation;
    // Use this for initialization
   
	// Update is called once per frame
	public void MoveToWaypoint () {
       
        cc = player.GetComponent<CharacterController>();
        targetPosition = this.transform.position;
        targetRotation = this.transform.rotation;
        //Debug.Log(targetPosition);
        this.GetComponent<SphereCollider>().enabled = false;
        cc.transform.SetPositionAndRotation(targetPosition, targetRotation);
        Invoke("reEnableCollider", 2);

        

	}
    private void reEnableCollider()
    {
        this.GetComponent<SphereCollider>().enabled = true;
    }
}

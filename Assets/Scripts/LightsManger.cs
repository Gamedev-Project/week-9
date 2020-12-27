using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsManger : MonoBehaviour
{
	void OnTriggerStay(Collider other){
		if(other.tag == "Player"&&Input.GetKeyDown(KeyCode.X)){
			this.GetComponentInChildren<Light>().enabled=!this.GetComponentInChildren<Light>().enabled;
		}
	}
}

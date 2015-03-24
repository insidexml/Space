using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "Boundary") {	//to make sure that it doesn't run into the boundary
			return;
		}
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}

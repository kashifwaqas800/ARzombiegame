using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buletdestry : MonoBehaviour {
	public GameObject vfx;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (this.gameObject,1f);
	}
	void OnTriggerEnter(Collider col){

		if (col.tag == "cooper") {
			//print ("working");
			vfx.SetActive (true);
			Destroy (this.gameObject,1f);

		}
	}
}

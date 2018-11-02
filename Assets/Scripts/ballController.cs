using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballController : MonoBehaviour {
	public Text text; 

	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "cone"){
			Renderer rend = col.gameObject.GetComponent<Renderer>();
			if(rend.material.color == gameObject.GetComponent<Renderer>().material.color){
				
			}
			Destroy(col.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

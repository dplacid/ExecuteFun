using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ballController : MonoBehaviour {
	private Text hud;
	//private int score = 0;

	// Use this for initialization
	void Start () {
		hud = GameObject.FindWithTag("points").GetComponent<Text>();;
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Cone"){
			Renderer rend = col.gameObject.GetComponent<Renderer>();
			if(rend.material.color == gameObject.GetComponent<Renderer>().material.color){
				if(rend.material.color == Color.red || rend.material.color == Color.blue){
					Debug.Log("hit");
					string hudText = hud.text;
					string[] splitHud = hudText.Split(' ');
					int score = Int32.Parse(splitHud[1]);
					score+=1;
					Debug.Log(score);
					hud.text = "Points: " + score;
					Destroy(col.gameObject);
				}
				
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

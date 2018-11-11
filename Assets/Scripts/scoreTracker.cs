using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class scoreTracker : MonoBehaviour {
	public Text points;
	public GameObject star;
	private int currentScore = 0;

	// Use this for initialization
	void Start () {
		points = points.gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		string hudText = points.text;
		string[] splitHud = hudText.Split(' ');
		Debug.Log(splitHud[0]);
		int score = Int32.Parse(splitHud[0]);
		if(score > currentScore){
			StartCoroutine(flash());
			currentScore = score;
		}
	}
	IEnumerator flash() {
    	for (int i = 0; i < 3; i++) {
			Debug.Log("Hi");
            star.gameObject.SetActive(true);
            yield return new WaitForSeconds(.2f);
            star.gameObject.SetActive(false);
			yield return new WaitForSeconds(.1f);
        }
    }  
}

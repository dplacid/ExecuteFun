using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballShooterScript : MonoBehaviour {
    public GameObject ball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        Rigidbody shot = Instantiate(ball.GetComponent<Rigidbody>(), ball.transform.position, ball.transform.rotation) as Rigidbody;
        shot.AddForce(ball.transform.forward * 1000f);
    }
}

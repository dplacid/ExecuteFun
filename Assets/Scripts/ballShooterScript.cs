using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballShooterScript : MonoBehaviour {
    public GameObject ball;
    public Button fireButton;

    // Use this for initialization
    void Start()
    {
        fireButton.onClick.AddListener(()=> shoot());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void shoot()
    {
        Rigidbody shot = Instantiate(ball.GetComponent<Rigidbody>(), ball.transform.position, ball.transform.rotation) as Rigidbody;
        shot.AddForce(ball.transform.forward * 1000f);
    }
}

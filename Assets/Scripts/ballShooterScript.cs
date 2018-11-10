using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballShooterScript : MonoBehaviour {
    public GameObject ball;
    public Button fireButton;
    private Color[] colors;
    private int color;

    // Use this for initialization
    void Start()
    {
        colors = new Color[] { Color.blue, Color.green, Color.red, Color.yellow};
        
        fireButton.onClick.AddListener(()=> shoot());
        // colors[0] = new Color(1, 0, 0, 1);
        // colors[1] = new Color(0, 0, 1, 1);
        // colors[2] = new Color(0, 1, 0, 1);
        // colors[3] = new Color(1, 0.92f, 0.016f, 1);

        color = Random.Range(0, 4);
        fireButton.GetComponent<UnityEngine.UI.Image>().color = colors[color];
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 offset = new Vector3(1, 0, 0);
        ball.transform.position = gameObject.transform.position;// - offset;
        ball.transform.eulerAngles = gameObject.transform.eulerAngles;
		
	}
    void shoot()
    {
        // mat.shader = Shader.Find("_Color");
        //mat.SetColor("_Color", colors[color]);
        // ball.gameObject.GetComponent<Renderer>().material.SetColor("_Color",colors[color]);
        Rigidbody shot = Instantiate(ball.GetComponent<Rigidbody>(), ball.transform.position, ball.transform.rotation) as Rigidbody;
        // Renderer rend = ball.gameObject.GetComponent<Renderer>();
        // rend.sharedMaterial.shader = Shader.Find("_Color");
        // rend.sharedMaterial.SetColor("_Color", colors[color]);
        shot.gameObject.GetComponent<Renderer>().material.SetColor("_Color",colors[color]);

        // shot.GetComponent<Renderer>().SetColor("_Color", Button.gameObject.GetComponent<UnityEngine.UI.Image>().color);
        shot.AddForce(ball.transform.forward * 1000f);
        color = Random.Range(0, 4);
        fireButton.gameObject.GetComponent<UnityEngine.UI.Image>().color = colors[color];
    }
}

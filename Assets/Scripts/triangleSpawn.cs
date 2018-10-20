using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triangleSpawn : MonoBehaviour {
    public GameObject[] cones;
    private IEnumerator coroutine;

	// Use this for initialization
	void Start () {
        //coroutine = waitToSpawn();
        //StartCoroutine(coroutine);
        //cones[0].SetActive(true);
        cones[0].gameObject.GetComponent<Color> = Color.red; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator waitToSpawn(){
        Debug.Log("made it");
        while (true) {
            yield return new WaitForSeconds(50f);
            print("WaitAndPrint " + Time.time);
        }
    }
}

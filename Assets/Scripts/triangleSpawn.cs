using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triangleSpawn : MonoBehaviour {
    //private IEnumerator coroutine;
    public float destroyTime = 10.0f; // when to end spawning
    public float rotateSpeed = 100.0f; // rotating the gameObjects (Cones)

    // Use this for initialization
    void Start () {
        Destroy(gameObject, destroyTime); // timer commense
        //coroutine = waitToSpawn();
        //StartCoroutine(coroutine);
        //cones[0].SetActive(true);
        //cones[0].gameObject.GetComponent<Renderer>().material.SetColor("_Color",Color.red);
	}
    void updated(){
        transform.Rotate(Vector3.forward * Time.deltaTime * rotateSpeed); // direction to rotate and speed/time
    }

	// Update is called once per frame
	//void Update () {
		
	//}

    /*IEnumerator waitToSpawn(){
        Debug.Log("made it");
        while (true) {
            yield return new WaitForSeconds(50f);
            print("WaitAndPrint " + Time.time);
        }
    }*/
}

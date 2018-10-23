using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public Transform[] SpawnPoints; // creates list for Spawn presets
    public float spawnTime = 1.5f; // after how long each object will be present
    //public GameObject Cone;
    public GameObject[] Cones; // creates list for Cones that will Spawn


    void Start() // initates code and only runs once throughout each session
    {
        InvokeRepeating("SpawnCones", spawnTime, spawnTime); //starts the Spawning process
    }

    void Update(){ // it's lonely

    }

    void SpawnCones()
    {
        int spawnIndex = Random.Range(0, SpawnPoints.Length); // how many points/presets (Emptys)
        int objectIndex = Random.Range(0, Cones.Length); // stores length variable of Cones
        Instantiate(Cones[objectIndex], SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation); // makes copy and distributes Spawns randomonly
    }

    /*public GameObject GameObject1;
    public Transform SpawnPoint;
    public Vector3 Pos;
    public Quaternion Rot;

	// Update is called once per frame
	void Update () {
        Pos = SpawnPoint.position;
        Rot = SpawnPoint.rotation;
        GameObject cone = Instantiate(GameObject1, Pos, Rot) as GameObject;
	}*/
}

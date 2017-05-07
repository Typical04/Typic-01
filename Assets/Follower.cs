using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 newPosition = transform.position;
        newPosition.z = -10;
        newPosition.y = newPosition.y - 2;
        newPosition.x = 0;
        Camera.main.transform.position = newPosition;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {

    public float Speed = 5f;
	
	// Update is called once per frame
	void Update () {

        float rightSpeed = Input.GetAxis("Horizontal");

        float upSpeed = Input.GetAxis("Vertical");

        transform.Translate(0, 0, Speed * upSpeed * Time.deltaTime);
        transform.Translate(Speed * rightSpeed * Time.deltaTime, 0, 0);
    }
}

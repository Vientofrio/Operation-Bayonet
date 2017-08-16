using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 6f;              // Player speed
    public float turningSpeed = 60;
    public float jumpSpeed = 10f;
    

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);
        float vertical = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        transform.Translate(0, 0, vertical);

        if (Input.GetKeyDown ("space"))
        {
            transform.Translate(Vector3.up * jumpSpeed * Time.deltaTime);
        }
        
	}

}

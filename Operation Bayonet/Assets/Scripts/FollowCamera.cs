using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    public Transform target;
    public float smoothing = 10f;
    public Vector3 offset;

	// Use this for initialization
	void Start () {
        	
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothing * Time.deltaTime);
        transform.position = smoothedPosition;

        transform.LookAt(target);
	}
}

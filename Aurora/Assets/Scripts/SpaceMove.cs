using UnityEngine;
using System.Collections;

public class SpaceMove : MonoBehaviour {

    private Transform myTransform;

    public float xMove;
    public float yMove;
    public float zMove;

	// Use this for initialization
	void Start () {
        myTransform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 movement = myTransform.position;
        movement.x += xMove * Time.deltaTime;
        movement.y += yMove * Time.deltaTime;
        movement.z += zMove * Time.deltaTime;
        myTransform.position = movement;
	}
}

using UnityEngine;
using System.Collections;

public class StayInPosition : MonoBehaviour {
    private Transform myTransform;

	// Use this for initialization
	void Start () {
        myTransform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
        myTransform.localPosition = new Vector3(0,0,0);
	}
}

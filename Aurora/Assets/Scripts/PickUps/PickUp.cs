using UnityEngine;
using System.Collections;

public abstract class PickUp : MonoBehaviour {

    public GameObject playerHit;

    // Handles collitions
    void OnTriggerEnter(Collider otherObject)
    {
        if(otherObject.tag == "Player")
        {
            playerHit = otherObject.gameObject;
            Effect();
        }
    }

    //Handles the effect that the pickup has
    public abstract void Effect();
}

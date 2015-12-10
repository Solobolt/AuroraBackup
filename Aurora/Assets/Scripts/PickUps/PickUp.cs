using UnityEngine;
using System.Collections;

public abstract class PickUp : MonoBehaviour {

    // Handles collitions
    void OnTriggerEnter(Collider otherObject)
    {
        if(otherObject.tag == "Player")
        {
            Effect();
        }
    }

    //Handles the effect that the pickup has
    public abstract void Effect();
}

using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour {

    //Makes the shield functional
    void OnCollisionEnter(Collision otherObject)
    {
        print("Shield hit");
        if (otherObject.gameObject.tag == "EnemyLaser")
        {
            Destroy(otherObject.gameObject);
        }
    }
}

using UnityEngine;
using System.Collections;
using System;

public class SpareParts : PickUp {
    public override void Effect()
    {
        playerHit.GetComponent<PlayerMovement>().AddHealh(500);
        Destroy(this.gameObject);
    }
}

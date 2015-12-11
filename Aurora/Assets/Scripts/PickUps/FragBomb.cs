using UnityEngine;
using System.Collections;

public class FragBomb : PickUp {

    public int projectileNum = 6;

    public GameObject projectile;

    private Transform myTransfrom;

    public override void Effect()
    {
        float angleDiff = 360 / projectileNum;

        for (int i = 0; i <= projectileNum; i++)
        {
            Instantiate(projectile, myTransfrom.position, Quaternion.Euler(0, (angleDiff * (float)i), 0));
        }
        Destroy(this.gameObject);
    }

    // Use this for initialization
    void Start () {
        myTransfrom = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

﻿using UnityEngine;
using System.Collections;

public class WeaponSwap : MonoBehaviour {

    public int weaponNum;
    private int playerNum;
    private int currentWeapon;

    public GameObject singleFireLaser;
    public GameObject dualFireLaser;
    public GameObject rocketBattery;

    // Use this for initialization
    void Start () {
        playerNum = this.gameObject.GetComponent<PlayerMovement>().playerNumb;
        if(playerNum == 1)
        {
            weaponNum = CustomShip.P1WeaNum;
        }
        else
        {
            weaponNum = CustomShip.P2WeaNum;
        }

        checkWeaponNumber();

	}
	
	// Update is called once per frame
	void Update () {
        checkWeaponNumber();
	}

    //checks to see if the weapon number has changed
    public void checkWeaponNumber()
    {
        if(weaponNum != currentWeapon)
        {
            setWeapon();
            currentWeapon = weaponNum;
        }
    }

    //Changes the weapon according to the numbre
    void setWeapon()
    {
        switch(weaponNum)
        {
            case 1:
                singleFireLaser.gameObject.SetActive(true);
                dualFireLaser.gameObject.SetActive(false);
                rocketBattery.gameObject.SetActive(false);
                break;

            case 2:
                singleFireLaser.gameObject.SetActive(false);
                dualFireLaser.gameObject.SetActive(true);
                rocketBattery.gameObject.SetActive(false);
                break;

            case 3:
                singleFireLaser.gameObject.SetActive(false);
                dualFireLaser.gameObject.SetActive(false);
                rocketBattery.gameObject.SetActive(true);
                break;

            default:
                singleFireLaser.gameObject.SetActive(true);
                dualFireLaser.gameObject.SetActive(false);
                rocketBattery.gameObject.SetActive(false);
                break;
        }
    }
}

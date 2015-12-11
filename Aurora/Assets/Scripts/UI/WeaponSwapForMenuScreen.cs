using UnityEngine;
using System.Collections;

public class WeaponSwapForMenuScreen : MonoBehaviour 
{

    //Weapon swap variables
    public int weaponNum;
    private int playerNum;
    private int currentWeapon;

    public GameObject singleFireLaser;
    public GameObject dualFireLaser;
    public GameObject rocketBattery;

    //Engine swap variables
    public int engineNum;
    private PlayerMovement playerMovement;

    public GameObject simpleEngine;
    public GameObject powerfullEngine;
    public GameObject advancedEngine;

    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        checkWeaponNumber();
        checkEngineNumber();
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

    
    //checks to see if the weapon number has changed
    public void checkEngineNumber()
    {
        if (engineNum != currentWeapon)
        {
            setEngine();
            currentWeapon = engineNum;
        }
    }

    //Changes the weapon according to the numbre
    void setEngine()
    {
        switch (engineNum)
        {
            case 1:
                simpleEngine.gameObject.SetActive(true);
                powerfullEngine.gameObject.SetActive(false);
                advancedEngine.gameObject.SetActive(false);
                playerMovement.SetSpeed(20);
                break;

            case 2:
                simpleEngine.gameObject.SetActive(false);
                powerfullEngine.gameObject.SetActive(true);
                advancedEngine.gameObject.SetActive(false);
                playerMovement.SetSpeed(30);
                break;

            case 3:
                simpleEngine.gameObject.SetActive(false);
                powerfullEngine.gameObject.SetActive(false);
                advancedEngine.gameObject.SetActive(true);
                playerMovement.SetSpeed(45);
                break;

            default:
                simpleEngine.gameObject.SetActive(true);
                powerfullEngine.gameObject.SetActive(false);
                advancedEngine.gameObject.SetActive(false);
                playerMovement.SetSpeed(20);
                break;
        }
    }
}



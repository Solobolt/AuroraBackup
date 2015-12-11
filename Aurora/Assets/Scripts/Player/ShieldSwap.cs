using UnityEngine;
using System.Collections;

public class ShieldSwap : MonoBehaviour {

    public int engineNum;
    private int playerNum;
    private int currentWeapon;

    private PlayerMovement playerMovement;

    // Use this for initialization
    void Start()
    {
        playerMovement = this.gameObject.GetComponent<PlayerMovement>();
        playerNum = playerMovement.playerNumb;
        if (playerNum == 1)
        {
            engineNum = CustomShip.P1ShiNum;
        }
        else
        {
            engineNum = CustomShip.P2ShiNum;
        }

        checkEngineNumber();

    }

    // Update is called once per frame
    void Update()
    {
        checkEngineNumber();
    }

    //checks to see if the weapon number has changed
    public void checkEngineNumber()
    {
        if (engineNum != currentWeapon)
        {
            setWeapon();
            currentWeapon = engineNum;
        }
    }

    //Changes the weapon according to the numbre
    void setWeapon()
    {
        switch (engineNum)
        {
            case 1:
                playerMovement.SetHealth(100);
                break;

            case 2:
                playerMovement.SetHealth(150);
                break;

            case 3:
                playerMovement.SetHealth(200);
                break;

            default:
                playerMovement.SetHealth(100);
                break;
        }
    }
}

using UnityEngine;
using System.Collections;

public class EngineSwap : MonoBehaviour {

    public int engineNum;
    private int playerNum;
    private int currentWeapon;
    private PlayerMovement playerMovement;

    public GameObject simpleEngine;
    public GameObject powerfullEngine;
    public GameObject advancedEngine;

    // Use this for initialization
    void Start()
    {
        playerMovement = this.gameObject.GetComponent<PlayerMovement>();
        playerNum = playerMovement.playerNumb;
        if (playerNum == 1)
        {
            engineNum = CustomShip.P1EngNum;
        }
        else
        {
            engineNum = CustomShip.P2EngNum;
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

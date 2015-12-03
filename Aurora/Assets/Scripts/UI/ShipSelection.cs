using UnityEngine;
using System.Collections;

public class ShipSelection : MonoBehaviour {
    public static int P1Ship = 1;
    public static int P2Ship = 1;


    public GameObject P1AtkModel;
    public GameObject P1DefModel;
    public GameObject P2AtkModel;
    public GameObject P2DefModel;

    // Use this for initialization
    void Start () {
        P1DefModel.SetActive(false);
        P2DefModel.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    //Sets the player 1st players ship type
    public void P1SetShipType(int ship)
    {
        P1Ship = ship;
        ChangeP1Model(ship);
    }

    //Sets the player 1st players ship type
    public void P2SetShipType(int ship)
    {
        P2Ship = ship;
        ChangeP2Model(ship);
    }

    public void PlayLevel()
    {
        Application.LoadLevel("InGame");
    }

    public void MoveToCustom()
    {
        Application.LoadLevel("CustomizationMenu");
    }


    public void ChangeP1Model(int modelNumber)
    {
        switch(modelNumber)
        {
            case 1:
                P1AtkModel.SetActive(true);
                P1DefModel.SetActive(false);
                break;

            case 2:
                P1AtkModel.SetActive(false);
                P1DefModel.SetActive(true);
                break;
            default:
                P1AtkModel.SetActive(true);
                P1DefModel.SetActive(false);
                break;
        }
    }

    public void ChangeP2Model(int modelNumber)
    {
        switch (modelNumber)
        {
            case 1:
                P2AtkModel.SetActive(true);
                P2DefModel.SetActive(false);
                break;

            case 2:
                P2AtkModel.SetActive(false);
                P2DefModel.SetActive(true);
                break;
            default:
                P2AtkModel.SetActive(true);
                P2DefModel.SetActive(false);
                break;
        }
    }
}

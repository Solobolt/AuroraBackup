using UnityEngine;
using System.Collections;

public class BodySwap : MonoBehaviour {
    private Transform myTransform;

    public GameObject model1;
    public GameObject model2;

    private PlayerMovement parent1;
    private int playerNumber = 1;

	// Use this for initialization
	void Start () {
        parent1 = this.gameObject.GetComponentInParent<PlayerMovement>();
        playerNumber = parent1.playerNumb;
        setModel(playerNumber);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void setModel(int playerNumber)
    {

       switch(playerNumber)
        {
            case 1:
                if(ShipSelection.P1Ship==1)
                {
                    model1.SetActive(true);
                    model2.SetActive(false);
                }
                else
                {
                    model1.SetActive(false);
                    model2.SetActive(true);
                }
                
                break;
            case 2:
                if (ShipSelection.P2Ship == 1)
                {
                    model1.SetActive(true);
                    model2.SetActive(false);
                }
                else
                {
                    model1.SetActive(false);
                    model2.SetActive(true);
                }
                break;

            default:
                print("ERROR BodySwap Player NUm");
                break;
        }

     

    }



}

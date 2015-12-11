using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CustomShip : MonoBehaviour {

    public static int P1EngNum = 1;
    public static int P1WeaNum = 1;
    public static int P1ShiNum = 1;

    public static int P2EngNum = 1;
    public static int P2WeaNum = 1;
    public static int P2ShiNum = 1;

    public Text budgetText;

    private Budget budget;

	// Use this for initialization
	void Start () {

        budget = GameObject.FindGameObjectWithTag("Budget").GetComponent<Budget>();

        budgetText.text = "BUDGET: " + GameController.totalScore;

        //This next code is only for the GAMEDEMO of level 2
        budgetText.text = "BUDGET: " + 25000;

    }
	
	// Update is called once per frame
	void Update () {
	
	}


    //Hold player 1 variables
    public void setP1Engine(int number)
    {
        P1EngNum = number;
        budget.SetP1EngCost(number * 5000);
    }

    public void setP1Weapon(int number)
    {
        P1WeaNum = number;
        budget.SetP1WeaCost(number * 5000);
    }

    public void setP1Shield(int number)
    {
        P1ShiNum = number;
        budget.SetP1ShiCost(number * 5000);
    }

    //Hold player 2 variables
    public void setP2Engine(int number)
    {
        P2EngNum = number;
        budget.SetP2EngCost(number * 5000);
    }

    public void setP2Weapon(int number)
    {
        P2WeaNum = number;
        budget.SetP2WeaCost(number * 5000);
    }

    public void setP2Shield(int number)
    {
        P2ShiNum = number;
        budget.SetP2ShiCost(number * 5000);
    }

    public void playLevel()
    {
        Application.LoadLevel("InGame");
    }
}

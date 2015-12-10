using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CustomShip : MonoBehaviour {

    public Text budgetText;

	// Use this for initialization
	void Start () {
        budgetText.text = "BUDGET: " + GameController.totalScore;

        //This next code is only for the GAMEDEMO of level 2
        budgetText.text = "BUDGET: " + 25000;

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void playLevel()
    {
        Application.LoadLevel("InGame");
    }
}

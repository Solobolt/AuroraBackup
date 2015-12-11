using UnityEngine;
using System.Collections;

public class LeaderBoard : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //replays the level
    public void ReplayLevel()
    {
        Application.LoadLevel("InGame");
    }

   //loads the main menu
    public void mainMenu()
    {
        Application.LoadLevel("MainMenu");
    }


}

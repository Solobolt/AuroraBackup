using UnityEngine;
using System.Collections;

public class PauseMenuControlls : MonoBehaviour {

    private GameObject uiController;

	// Use this for initialization
	void Start () {
        uiController = GameObject.FindGameObjectWithTag("UIController");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //toggles the pause menu
    public void resumeGame()
    {
        uiController.gameObject.GetComponent<PauseMenu>().togglePaused();
    }

    //Restarts the Level
    public void restartGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    //quits the game
    public void quitGame()
    {
        Application.Quit();
    }

    //loads the main menu
    public void mainMenu()
    {
        Application.LoadLevel("MainMenu");
    }

    //loads a desired scene
    public void LoadLevel(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }

}

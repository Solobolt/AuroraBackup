using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class MainMenuController : MonoBehaviour {

    //Loads a specified level
    //FOR DEMO LOAD LEVEL 1
    //Exicutes on start
    void Start()
    {

    }

    //Executes every frame
    void Update()
    {
        
    }

    public void goToCustom()
    {
        Application.LoadLevel("CustomizationMenu");
    }

    public void loadLevel()
    {
        Application.LoadLevel("ShipSelection");
    }
    public void loadOptions()
    {
        Application.LoadLevel("Options");
    }

	public void loadMenu()
	{
		Application.LoadLevel ("MainMenu");
	}


    //Exits the game (Doesnt work in editor but does work in executable)
    public void quitGame()
    {
        Application.Quit();
    }

}

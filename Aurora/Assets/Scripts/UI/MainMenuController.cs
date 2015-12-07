using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class MainMenuController : MonoBehaviour {

    public Button[] menuButtons;
    private Button currentButton;
    private int buttonNum = 0;
    PointerEventData pointer;
    private bool hasMoved = false;

    //Loads a specified level
    //FOR DEMO LOAD LEVEL 1
    //Exicutes on start
    void Start()
    {
        if (menuButtons.Length != 0)
        {
            currentButton = menuButtons[0];
            currentButton.Select();
        }
    }

    //Executes every frame
    void Update()
    {
        if(menuButtons.Length != 0)
        {
            controllerInput();
        }
        
    }

    void controllerInput()
    {
        float stickVal = Input.GetAxis("P1_Vertical");

        if (stickVal != 0)
        {
            if (hasMoved == false)
            {
                if (stickVal < 0)
                {
                    hasMoved = true;
                    buttonNum++;
                    if (buttonNum > menuButtons.Length - 1)
                    {
                        buttonNum = 0;
                    }
                }
                if (stickVal > 0)
                {
                    hasMoved = true;
                    buttonNum--;
                    if (buttonNum < 0)
                    {
                        buttonNum = menuButtons.Length - 1;
                    }
                }
            }

        }
        else
        {
            hasMoved = false;
        }

        currentButton = menuButtons[buttonNum];
        currentButton.Select();
        //currentButton.GetComponent<Button>().OnClick();
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

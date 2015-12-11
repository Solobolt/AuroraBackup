using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player2UINav : MonoBehaviour {

    public Button[] menuButtons;
    private Button currentButton;
    private int buttonNum = 0;
    private bool hasMoved = false;

    // Use this for initialization
    void Start () {
        if (menuButtons.Length != 0)
        {
            currentButton = menuButtons[0];
            currentButton.Select();
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (menuButtons.Length != 0)
        {
            controllerInput();
        }
    }

    void controllerInput()
    {
        float stickVal = Input.GetAxis("P2_Vertical");

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
    }
}

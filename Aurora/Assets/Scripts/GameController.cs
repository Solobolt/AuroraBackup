﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    private GameObject[] explotions;

    //Holds a list of the controllers registered to the pc
    private string[] controllers;

    //Values depening on the player
     public static int totalScore;

    //Hold the number of players from the number of controllers
    public int numPlayers = 0;

    //deteramins how far appart players spawn
    private int spawnDistance = 2;

    //Sets a boarder for player movement
    public float VertWall = 10.0f;
    public float HoriWall = 17.5f;

    //Player Prefab
    public GameObject player;
    public List<PlayerMovement> PlayerList = new List<PlayerMovement>();
    private bool isNumbSet = false;

    public GameObject gameOverScreen;
    private bool gameOverIsUp = false;
    // Use this for initialization
    void Start()
    {
        numPlayers = 1;
        Debug.Log("GAme starting");
        CheckControllers();
        createPlayers();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        setPlayerNumb();
        if(numPlayers == 0)
        {
            if(gameOverIsUp == false)
            {
                print(totalScore);
                Instantiate(gameOverScreen);
                gameOverIsUp = true;
            }
            
        }
        explotions = GameObject.FindGameObjectsWithTag("Explotion");
        for (int i = 0; i < explotions.Length; i++)
        {
            Destroy(explotions[i], 1.0f);
        }
    }

    //sets the player numbers correctly
    private void setPlayerNumb()
    {
        //Having the bool check will prevent the game from rewriting strings every frame
        if (isNumbSet == false)
        {
            //Check if there is a second player that need its number changed
            if (numPlayers > 1)
            {
                PlayerList[1].playerNumb = 2;
                PlayerList[1].SetStrings();
            }
            isNumbSet = true;
        }
    }

    // Collects an array of controller inputs
    void CheckControllers()
    {
        controllers = Input.GetJoystickNames();
        for (int i = 0; i < Input.GetJoystickNames().Length; i++)
        {
            if (controllers[i] != null)
            {
                if (controllers[i] != "")
                {
                    //Adds to the number of players
                    numPlayers = i + 1;
                }
            }
        } 
    }

    //instantiates players
    void createPlayers()
    {
        switch (numPlayers)
        {
            case 0:
                Instantiate(player, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
                break;
            case 1:

                Instantiate(player, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
                break;

            case 2:
                for (int i = 1; i < (numPlayers + 1); i++)
                {
                    if (i == 2)
                    {
                        GameObject playerObject = Instantiate(player, new Vector3(spawnDistance * Mathf.Pow((-1), i), 0, 0), new Quaternion(0, 0, 0, 0)) as GameObject;
                        playerObject.GetComponent<PlayerMovement>().playerNumb = 2;
                    }
                    else
                    {
                        Instantiate(player, new Vector3(spawnDistance * Mathf.Pow((-1), i), 0, 0), new Quaternion(0, 0, 0, 0));
                    }
                }

                break;

            default:

                Debug.Log("Player Spawn error 'playerNumb'");

                break;
        }
    }

    //Adds a player to the list
    public void addPlayer(PlayerMovement playerMoveScript)
    {
        PlayerList.Add(playerMoveScript);
    }
}

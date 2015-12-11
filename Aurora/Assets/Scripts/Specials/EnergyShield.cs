using UnityEngine;
using System.Collections;
using System;

public class EnergyShield : MonoBehaviour {

    public GameObject shield;

    private string fire2;

    public int playerNumb;
    private bool numbChecked = false;

    private AudioController audioController;

    private Transform myTransform;

    // Use this for initialization
    void Start()
    {
        myTransform = this.transform;
        audioController = GameObject.FindGameObjectWithTag("AudioController").GetComponent<AudioController>();
        shield.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        shield.SetActive(false);
        SetStrings();
        CheckInputs();
    }

    //Handles Inputs
    void CheckInputs()
    {
        if (Input.GetAxis(fire2) != 0 || Input.GetMouseButton(1))
        {
            shield.SetActive(true);
        }
    }

    //Sets the controller strings
    void SetStrings()
    {
        if (numbChecked == false)
        {
            playerNumb = gameObject.GetComponentInParent<PlayerAiming>().playerNumb;
            fire2 = "P" + playerNumb + "_Fire2";
        }
    }

    
}

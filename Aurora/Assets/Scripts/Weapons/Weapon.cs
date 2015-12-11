using UnityEngine;
using System.Collections;

public abstract class Weapon : MonoBehaviour {

    private string fire1;
    private string fire2;

    public int playerNumb;
    private bool numbChecked = false;

    public AudioController audioController;

    public Transform myTransform;
    
    // Use this for initialization
    void Start () {
        myTransform = this.transform;
        audioController = GameObject.FindGameObjectWithTag("AudioController").GetComponent<AudioController>();
    }

    // Update is called once per frame
    void Update () {
        SetStrings();
        CheckInputs();
    }
    
    //Handles Inputs
    void CheckInputs()
    {
        if (Input.GetAxis(fire1) != 0||Input.GetMouseButton(0))
        {
            fireWeapon();
        }

        if(Input.GetAxis(fire2) != 0 || Input.GetMouseButton(1))
        {
            fireSpecial();
        }
    }

    //Sets the controller strings
    void SetStrings()
    {
        if (numbChecked == false)
        {
            playerNumb = gameObject.GetComponentInParent<PlayerAiming>().playerNumb;
            fire1 = "P" + playerNumb + "_Fire1";
            fire2 = "P" + playerNumb + "_Fire2";
        }
    }

    //Handles what happens when the player hits the fire button
    public abstract void fireWeapon();
    public abstract void fireSpecial();

}

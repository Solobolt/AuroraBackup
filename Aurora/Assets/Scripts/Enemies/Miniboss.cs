﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Miniboss : MonoBehaviour {

    //sets the miniboss's health
    private int health = 10000;
    private int TotalHealth = 10000;
    private int damage = 10;
    public Slider healthBarSlider;

    public GameObject GameOverScreen;

    //Weapon GameObjects
    public GameObject weapon1;
    public GameObject weapon2;
    public GameObject weapon3;
    
    // Use this for initialization
    void Start () {
        SetWeapons(true,false,false);
    }
	
	// Update is called once per frame
	void Update () {
        
	}
    
    //activates wepons
    void SetWeapons(bool _weapon1, bool _weapon2,bool _weapon3)
    {
        weapon1.SetActive(_weapon1);
        weapon2.SetActive(_weapon2);
        weapon3.SetActive(_weapon3);
    }

    // Removes health if the player is hit by a laser
    void OnTriggerEnter(Collider otherObject)
    {
        if(otherObject.gameObject.tag == "Laser")
        {
            RemoveHealth(damage);
            Destroy(otherObject.gameObject);
        }
    }

    //Changes weapon depedning on the health of the boss
    void healthWeaponCheck()
    {
        //swaps the enemy weapon 
        if (((float)health <= (float)TotalHealth * 0.6f) && ((float)health > (float)TotalHealth * 0.3f))
        {
            SetWeapons(false,true,false);
        }

        if ((float)health <= (float)TotalHealth * 0.3f)
        {
            SetWeapons(false, false, true);
        }
    }

    //Removes health
   public void RemoveHealth(int amount)
    {
        health -= damage;
        //healthBarSlider.value = healthBarSlider.value - 0.001f;
        healthBarSlider.value = ((float)health/(float)TotalHealth);

        healthWeaponCheck();

        if (health <= 0)
        {
            GameController.totalScore += 5000;
            healthBarSlider.value = 0f;
            Destroy(this.gameObject);

            Instantiate(GameOverScreen);
        }
    }
}

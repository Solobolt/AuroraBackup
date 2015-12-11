using UnityEngine;
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

	//Hold the transform
	Transform myTransform;

	//Explosion
	public GameObject explosionWeapon;
	public AudioController audioController;
	public GameObject scoreRender;
	public int points=5000;
	  
    // Use this for initialization
    void Start () {
        SetWeapons(true,false,false);
		myTransform = this.transform;
		audioController = GameObject.FindGameObjectWithTag("AudioController").GetComponent<AudioController>();
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
            GameController.totalScore += points;
            healthBarSlider.value = 0f;
            Destroy(this.gameObject);
			audioController.playSound(audioController.EXP,audioController.enemyDeath,0.2f);
			Instantiate(explosionWeapon,myTransform.position,Quaternion.identity);
			Instantiate(explosionWeapon,new Vector3(-7.5f,0,5),Quaternion.identity);
			Instantiate(explosionWeapon,new Vector3(7.5f,0,5),Quaternion.identity);
			GameObject goldPopup = Instantiate (scoreRender, Camera.main.WorldToViewportPoint (transform.position + new Vector3 (0, 1, 0)), Quaternion.identity) as GameObject;
			goldPopup.GetComponent<GUIText>().text = gameObject.GetComponent<Miniboss> ().points.ToString ();
            Instantiate(GameOverScreen);
        }
    }
}

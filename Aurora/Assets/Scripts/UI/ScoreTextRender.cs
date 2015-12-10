using UnityEngine;
using System.Collections;

public class ScoreTextRender : MonoBehaviour
{
	private float fadeTimer = 3.0f;
	private float decreaseFactor = 3.0f;
	
	void Update ()
	{
		//Used for Score that Follows The Player. (So People Can Read Better).
		transform.Translate (new Vector3 (0, 0.1f, 0) * Time.deltaTime);   
		
		//Decrease The Timer.
		fadeTimer -= Time.deltaTime * decreaseFactor;	
		//Set alpha to the Timer Variable. (Fade Out)
		GetComponent<GUIText>().material.color = new Color (1, 1, 1, fadeTimer);	
		//GetComponent<TextMesh>().color= new Color (1, 1, 1, fadeTimer);
		Destroy (gameObject, fadeTimer);	
		
	}
}

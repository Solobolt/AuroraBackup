using UnityEngine;
using System.Collections;

public class LaserCannon : MonoBehaviour 
	{
    int playerNum;
    string contollerFire;
	LineRenderer line;
	Enemy enemies;	 
		
	void Start () 
	{
        playerNum = GetComponentInParent<PlayerMovement>().playerNumb;

        contollerFire = "P"+playerNum+"_Fire2";

		line = gameObject.GetComponent<LineRenderer>();
		line.enabled = false;
	}
	void Update () 
	{
        if (Input.GetMouseButton(1) || Input.GetAxis(contollerFire) != 0)
		{
			StopCoroutine("FireLaser");
			StartCoroutine("FireLaser");
		}
	}
	IEnumerator FireLaser()
	{
		line.enabled = true;
			
	while(Input.GetMouseButton(1) || Input.GetAxis(contollerFire) != 0)
		{
			Ray ray = new Ray(transform.position, transform.forward);
			RaycastHit hit;
				
			line.SetPosition(0, ray.origin);
				
			if(Physics.Raycast(ray, out hit, 100))
			{
				line.SetPosition(1, hit.point);
				if(hit.rigidbody)
				{
					hit.rigidbody.AddForceAtPosition(transform.forward * 10, hit.point);
				if(hit.collider.gameObject.tag=="Enemy" || hit.collider.gameObject.tag == "Miniboss")
				{
                    if(hit.collider.gameObject.GetComponent<Enemy>()!= null)
                    {
                        hit.collider.gameObject.GetComponent<Enemy>().RemoveHealth(5);
                    }
                    if (hit.collider.gameObject.GetComponent<Miniboss>() != null)
                    {
                        hit.collider.gameObject.GetComponent<Miniboss>().RemoveHealth(10);
                    }
                }
				}
			}
			else
				line.SetPosition(1, ray.GetPoint(100));
				
			yield return null;
		}
			
		line.enabled = false;
	}

	}
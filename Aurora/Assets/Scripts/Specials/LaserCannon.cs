using UnityEngine;
using System.Collections;

public class LaserCannon : MonoBehaviour 
	{
		LineRenderer line;
		Enemy enemies;	 
		
		void Start () 
		{
			line = gameObject.GetComponent<LineRenderer>();
			line.enabled = false;
		}
		void Update () 
		{
			if(Input.GetMouseButton(1))
			{
				StopCoroutine("FireLaser");
				StartCoroutine("FireLaser");
			}
		}
		IEnumerator FireLaser()
		{
			line.enabled = true;
			
		while(Input.GetMouseButton(1))
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
					if(hit.collider.gameObject.tag=="Enemy" || hit.collider.gameObject.tag == "Miniboos")
					{
                        if(hit.collider.gameObject.GetComponent<Enemy>()!= null)
                        {
                            hit.collider.gameObject.GetComponent<Enemy>().RemoveHealth(5);
                        }
                        if (hit.collider.gameObject.GetComponent<Miniboss>() != null)
                        {
                            hit.collider.gameObject.GetComponent<Miniboss>().RemoveHealth(5);
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
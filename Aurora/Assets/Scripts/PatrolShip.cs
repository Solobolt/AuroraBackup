using UnityEngine;
using System.Collections;

public class PatrolShip : MonoBehaviour 
{

    private Transform myTransorm;

    //Patrolling Variables
    public float patrolSpeed = 2.0f;
    public GameObject[] patrolPoints;
    public int currentPatrolPoint = 0;
    public float patrolPointDistance = 1.0f;

	// Use this for initialization
	void Start () 
    {
        myTransorm = this.transform;
	}
	
	// Update is called once per frame
	void Update () 
    {
        Patrol();
	}
    //Enemy Action - Patrol between provided points
    void Patrol()
    {
        //Snap rotation towards current patrol point
        myTransorm.LookAt(patrolPoints[currentPatrolPoint].transform.position);

        //Move in direction to patrol point
        myTransorm.Translate(Vector3.forward * Time.deltaTime * patrolSpeed);


        //Close to/arrived at patrol point. Switch to next/first patrol
        if (Vector3.Distance(myTransorm.position, patrolPoints[currentPatrolPoint].transform.position) < patrolPointDistance)
        {
            //Circular/reset patrol technique
            if (currentPatrolPoint == patrolPoints.Length - 1)
            {
                currentPatrolPoint = 0;
            }
            else
            {
                currentPatrolPoint++;
            }
        }
    }
}

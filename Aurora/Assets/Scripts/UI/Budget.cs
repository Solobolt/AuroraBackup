using UnityEngine;
using System.Collections;

public class Budget : MonoBehaviour {

    public int P1Budget;
    public int P2Budget;

    private int P1used;
    private int P2used;

    private int P1WeaCost;
    private int P1EngCost;
    private int P1ShiCost;

    private int P2WeaCost;
    private int P2EngCost;
    private int P2ShiCost;


    public void CalcP1Used()
    {
        P1used = P1ShiCost + P1EngCost + P1WeaCost;
    }

    public void CalcP2Used()
    {
        P1used = P2ShiCost + P2EngCost + P2WeaCost;
    }

    public void SetP1WeaCost(int cost)
    {
        P1WeaCost = cost;
    }

    public void SetP1EngCost(int cost)
    {
        P1EngCost = cost;
    }

    public void SetP1ShiCost(int cost)
    {
        P1ShiCost = cost;
    }


    public void SetP2WeaCost(int cost)
    {
        P2WeaCost = cost;
    }

    public void SetP2EngCost(int cost)
    {
        P2EngCost = cost;
    }

    public void SetP2ShiCost(int cost)
    {
        P2ShiCost = cost;
    }

    // Use this for initialization
    void Start () {
        P1Budget = GameController.totalScore;
        P2Budget = GameController.totalScore;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

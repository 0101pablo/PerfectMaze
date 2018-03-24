using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positions : MonoBehaviour {

    public int startXPos = -10;
    public int startYPos = 28;
    public GameObject finish;
    public int finishXPos = 29;
    public int finishYPos = -10;
    public GameObject Agent;

    // Use this for initialization
    void Start(){
        Instantiate(finish, new Vector3(finishXPos, 0f, finishYPos), Quaternion.identity);
        Instantiate(Agent, new Vector3(startXPos + 0.5f, 0.0f, startYPos + 0.5f), Agent.transform.rotation);
    }   
	
	// Update is called once per frame
	void Update () {
		
	}
}
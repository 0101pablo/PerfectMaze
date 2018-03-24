using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positions : MonoBehaviour {

    public GameObject Agent;
    public int startXPos = -5;
    public int startZPos = 13;
    
    /*public GameObject Finish;
    public int finishXPos = 10;
    public int finishZPos = -28;*/

    void Start(){

        //Instantiate(finish, new Vector3(finishXPos, 0f, finishZPos), Quaternion.identity);

        Instantiate(Agent, new Vector3(startXPos + 0.5f, 0.0f, startZPos + 0.5f), Agent.transform.rotation);
    }   
	
	void Update () {
		
	}
}
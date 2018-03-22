using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positions : MonoBehaviour {

    public int startXPos = -10;
    public int startYPos = 28;
    public GameObject finish;
    public int finishXPos = 29;
    public int finishYPos = -10;
    public GameObject sAgent;
    public GameObject nAgent;
    public bool smallAgent = false;

	// Use this for initialization
	void Start () {

        Instantiate(finish, new Vector3(finishXPos, 0f, finishYPos), Quaternion.identity);

        if (smallAgent) {
            Instantiate(sAgent, new Vector3(startXPos + 0.5f,0.0f,startYPos + 0.5f),Quaternion.identity);
        }
        else{
            Instantiate(nAgent, new Vector3(startXPos + 1f,0f,startYPos + 0f), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
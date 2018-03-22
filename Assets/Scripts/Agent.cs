using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{

    public int speed = 10;
    public int rotateSpeed = 1000;

    public GameObject nSensor;
    public GameObject eSensor;
    public GameObject wSensor;
    public bool n = false;
    public bool e = false;
    public bool w = false;

    int direction = 0; //0=N, 1=E, 2=S, 3=W

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ScanTriggers();

        if (n){
            if (e){
                transform.Rotate(Vector3.up * -90);
                ScanTriggers();
            }
            else{
                transform.Rotate(Vector3.up * 90);
                ScanTriggers();
            }
        }
        else
        {
            if (e){
                transform.position += transform.forward * 2;
                ScanTriggers();
            }
            else{
                transform.Rotate(Vector3.up * 90);
                transform.position += transform.forward * 2;
                ScanTriggers();
            }
        }

        if (Input.GetKey(KeyCode.Space))
        {
            //transform.localPosition += Vector3.forward;
            transform.position += transform.forward;
        }
    }

    void ScanTriggers()
    {
        if (ChildsTrigger.nChild) n = true;
        if (!ChildsTrigger.nChild) n = false;
        if (ChildsTrigger.eChild) e = true;
        if (!ChildsTrigger.eChild) e = false;
        if (ChildsTrigger.wChild) w = true;
        if (!ChildsTrigger.wChild) w = false;
    }
}

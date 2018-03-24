using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour{
    public int speed = 10;
    public int rotateSpeed = 10;
    private bool trigControl;

    void Update(){
        if (trigControl){
            transform.Rotate(Vector3.up * -rotateSpeed * 10 * Time.deltaTime);
            transform.position += -transform.right * speed / 10 * Time.deltaTime;        }
        else{
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other){
        trigControl = true;
    }

    private void OnTriggerExit(Collider other){
        trigControl = false;
    }
}

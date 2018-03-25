using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowMove : MonoBehaviour {

    private bool trigged = false;
    private bool nt, et, st, wt = false;

    void Update(){
        transform.position += transform.forward * Time.deltaTime;

        if (!trigged){
            transform.Rotate(Vector3.up * -225 * Time.deltaTime);
            transform.position += transform.forward * Time.deltaTime;
        }
    }

    private void OnTriggerStay(Collider other){
        trigged = true;

        Vector3 direction;
        direction = new Vector3();

        if (other.name == "RightFlow" || other.name == "LeftFlow") {

            int anguloY = Mathf.RoundToInt(other.transform.eulerAngles.y);
            direction.y = anguloY;
            switch (anguloY){
                case 0: {nt = true; break;} //north
                case 90: { et = true; break;} //east
                case 180: {st = true; break;} //south
                case 270: {wt = true; break;} //west
            }
            
            if (nt && et) direction.y = 45; //northeast
            if(et && st) direction.y = 135; //southeast
            if(st && wt) direction.y = 225; //southwest
            if(wt && nt) direction.y = 315; //northwest
            
            transform.eulerAngles = (transform.eulerAngles + direction) / 2;
        }
    }

    private void OnTriggerExit(Collider other){
        trigged = false;

        if (nt) nt = false;
        if (et) et = false;
        if (st) st = false;
        if (wt) wt = false;
    }
}

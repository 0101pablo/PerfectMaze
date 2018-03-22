using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildsTrigger : MonoBehaviour{

    public static bool nChild = false;
    public static bool eChild = false;
    public static bool wChild = false;
    public static bool sChild = false;

    private void Start(){

    }
    
    private void OnTriggerEnter(Collider other){
        switch (gameObject.name){
            case "NSensor": nChild = true; break;
            case "ESensor": eChild = true; break;
            case "WSensor": wChild = true; break;
            case "SSensor": wChild = true; break;
        }
    }

    private void OnTriggerExit(Collider other){
        switch (gameObject.name){
            case "NSensor": nChild = false; break;
            case "ESensor": eChild = false; break;
            case "WSensor": wChild = false; break;
            case "SSensor": wChild = false; break;
        }
    }
}

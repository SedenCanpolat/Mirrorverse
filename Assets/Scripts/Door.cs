using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
   public GameObject door;
   public GameObject cube;
   
   void OnTriggerEnter(Collider  other){
        if(other.gameObject.tag == "Spinning"){
          door.SetActive(false);
          cube.SetActive(false);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
      public int control;
      

      void OnTriggerEnter(Collider  other){
        if(other.gameObject.tag == "Spinning"){
          control = 1;
          }
        }
       
       void OnTriggerExit(Collider  other){
         if(other.gameObject.tag == "Spinning"){
          control = 2;
          }
        }
}

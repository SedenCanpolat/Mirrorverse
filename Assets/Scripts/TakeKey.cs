using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TakeKey : MonoBehaviour
{
   public GameObject oppositeKey;
  
   public Image key;
   private void Start() {
        key.enabled = false;
   }
   void OnMouseDown() {
        if(gameObject.tag == "Key"){
            Destroy(gameObject);
            Destroy(oppositeKey);
            key.enabled = true;
        }
    
        
    }

    
       



}

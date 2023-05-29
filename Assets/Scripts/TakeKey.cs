using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TakeKey : MonoBehaviour
{
   // Sansur ayna arkasındaki cube almak için 
   // Opposite olan red ve normalde arkadaydı sadece tag yerlerini degistirdim
  // public GameObject oppositeKey;
  
   public Image key;
   private void Start() {
        key.enabled = false;
   }
   void OnMouseDown() {
        if(gameObject.tag == "Key"){
            Destroy(gameObject);
          //  Destroy(oppositeKey);
            key.enabled = true;
        }
    
        
    }

    
       



}

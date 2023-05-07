using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Slider healthBar;
    bool isGameOver;
    
 

    private void OnControllerColliderHit(ControllerColliderHit hit) {
        Rigidbody rigidbody = hit.collider.attachedRigidbody;
        if(rigidbody!= null && hit.gameObject.tag == "Spike"){
            healthBar.value -= 0.005f;
            
        }
        
         if(hit.gameObject.tag == "Fog"){
               hit.gameObject.GetComponent<FallenGround>().fall();
        }

        if(healthBar.value <= 0 && isGameOver == false){
            Debug.Log("You Lost");
            isGameOver = true;
        }
    }


    private void Update() {

        if(gameObject.transform.position.y < -5  && isGameOver == false){
            healthBar.value = 0;
            Debug.Log("You Lost");
            isGameOver = true;
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Slider healthBar;
    bool isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        //healthBar.value = 1;
    }




    private void OnControllerColliderHit(ControllerColliderHit hit) {
        Rigidbody rigidbody = hit.collider.attachedRigidbody;
        if(rigidbody!= null && hit.gameObject.tag == "Spike"){
            healthBar.value -= 0.005f;
            
        }
        if(healthBar.value <= 0 && isGameOver == false){
            Debug.Log("You Lost");
            isGameOver = true;
        }
    }

    private void Update() {
        
        
    }


}

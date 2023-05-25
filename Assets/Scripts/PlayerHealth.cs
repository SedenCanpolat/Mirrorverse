using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public Slider healthBar;
    bool isGameOver;

    
   /* public Image[] hearts;
    public GameObject Danger;
    private void EnableFalse(){
      //  Danger.SetActive(false);
        for(int i = 0; i < 5; i++){
            hearts[i].enabled = false;
        }
    }
    */
    private void OnControllerColliderHit(ControllerColliderHit hit) {
        Rigidbody rigidbody = hit.collider.attachedRigidbody;
        // rigidbody!= null &&
        if(hit.gameObject.tag == "Spike"){
            healthBar.value -= 0.005f;
            Debug.Log("Spike");
            
        }

        /*
        if(healthBar.value == 1){
            EnableFalse();
            hearts[0].enabled = true;
        }

        if(healthBar.value <= 0.90){
            EnableFalse();
            hearts[1].enabled = true;
        }

        if(healthBar.value <= 0.60){
            EnableFalse();
            hearts[2].enabled = true;
        }

         if(healthBar.value <= 0.40){
            EnableFalse();
            hearts[3].enabled = true;
        }

         if(healthBar.value <= 0.20){
            EnableFalse();
            hearts[4].enabled = true;
        }

        if(healthBar.value <= 0.10){
           // Danger.SetActive(true);
        }

        if(healthBar.value == 0){
            Debug.Log("You Lost");
           // yield return new WaitForSeconds(3f);
            SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex);
        }
        */
        
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

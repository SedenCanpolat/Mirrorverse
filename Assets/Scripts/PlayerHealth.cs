using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public Slider healthBar;
    bool isGameOver;

    
   //public Image[] hearts;
   public Sprite[] heartsSpite;
   public Image heart;
    public GameObject Danger;
    public GameObject YouDead;
/*
    private void EnableFalse(){
        Danger.SetActive(false);
        for(int i = 0; i < 5; i++){
            hearts[i].enabled = false;
        }
    }
*/    
    private void OnControllerColliderHit(ControllerColliderHit hit) {
        Rigidbody rigidbody = hit.collider.attachedRigidbody;
        // rigidbody!= null &&
        if(hit.gameObject.tag == "Spike"){
            healthBar.value -= 0.0015f;
            Debug.Log("Spike");
            
        }

        
        if(healthBar.value == 1){
          //  EnableFalse();
          //  hearts[0].enabled = true;
          heart.sprite = heartsSpite[0];
        }

        if(healthBar.value <= 0.90){
          //  EnableFalse();
          //  hearts[1].enabled = true;
            heart.sprite = heartsSpite[1];
        }

        if(healthBar.value <= 0.60){
          //  EnableFalse();
          // hearts[2].enabled = true;
          heart.sprite = heartsSpite[2];
        }

         if(healthBar.value <= 0.40){
           // EnableFalse();
           // hearts[3].enabled = true;
           heart.sprite = heartsSpite[3];
        }

         if(healthBar.value <= 0.20){
          //  EnableFalse();
          //  hearts[4].enabled = true;
          heart.sprite = heartsSpite[4];
        }

        if(healthBar.value <= 0.13){
            Danger.SetActive(true);
        }

        if(healthBar.value == 0){
            Debug.Log("You Lost");
            YouDead.SetActive(true);
            FindObjectOfType<PlayerMovement>().enabled = false;
            if(Input.GetKey(KeyCode.R)){
              SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex);
            } 
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

        if(gameObject.transform.position.y < -10  && isGameOver == false){
            healthBar.value = 0;
            Debug.Log("You Lost");
            isGameOver = true;
            YouDead.SetActive(true);
            
        }

        if(Input.GetKey(KeyCode.R)){
              SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex);
            } 

    }


}

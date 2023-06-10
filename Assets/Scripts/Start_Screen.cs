using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Screen : MonoBehaviour
{
    
    public GameObject camera;
    public GameObject capsule;
    public GameObject cursor;
    public GameObject healthbar;
    
    public GameObject screen;
    public GameObject icon;

 private void Awake(){
    FindObjectOfType<PlayerMovement>().enabled = false;
    camera.GetComponent<MouseLook>().enabled = false;
    Cursor.lockState = CursorLockMode.None;
}
    

    public void Game(){
        
        print("d");
        capsule.SetActive(true);
        cursor.SetActive(true);
        healthbar.SetActive(true);
        
        camera.GetComponent<MouseLook>().enabled = true;
        FindObjectOfType<PlayerMovement>().enabled = true;
        
        screen.SetActive(false);
        icon.SetActive(false);
    }
    



}

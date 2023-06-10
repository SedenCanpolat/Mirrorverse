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


    public void Game(){
        print("d");
        capsule.SetActive(true);
        cursor.SetActive(true);
        healthbar.SetActive(true);
        screen.SetActive(false);
        camera.GetComponent<MouseLook>().enabled = true;
        icon.SetActive(false);
    }


}

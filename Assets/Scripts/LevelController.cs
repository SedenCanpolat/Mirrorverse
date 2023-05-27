
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
  
   public int sceneNum;

   void OnTriggerEnter(Collider  other){
        if(other.gameObject.tag == "level"){
          print("aa");
          SceneManager.LoadScene(sceneNum);
        }
        
    }

}

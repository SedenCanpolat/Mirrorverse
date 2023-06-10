
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
   [SerializeField] Image loadingScreen; 
   public int sceneNum;

   private void Start() {
    loadingScreen.enabled = false;
   }

   void OnTriggerEnter(Collider  other){
        if(other.gameObject.tag == "level"){
          print("aa");
          loadingScreen.enabled = true;
          SceneManager.LoadScene(sceneNum);
        }
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; ///
// yield return eklenebilir birden kaybolmama nedeniyle

public class OpenMirror : MonoBehaviour
{
   //  public GameObject mirror; gerek yok this.gameObject kullanınca
     public Image key;
     public Image DemoEnding;

     private void Start() {
      key.enabled = false;
      DemoEnding.enabled = false;
     }

   // void OnMouseDown(){
   //  if(gameObject.tag == "Mirror" && key.enabled == true){ 
    void OnTriggerEnter(Collider  other){
      if(gameObject.tag == "Mirror"){
          if(key.enabled == true){
           // Destroy(this.gameObject);
            DemoEnding.enabled = true;
            key.enabled = false;
            Controls.controls.WhenPressR += LevelControl.levelControl.RestartGame;
            Controls.controls.WhenPressR -= LevelControl.levelControl.LevelRestart;
            }
         }
    }


  
}

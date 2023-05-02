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
    void OnMouseDown(){
     if(gameObject.tag == "Mirror" && key.enabled == true){ ////
            Destroy(this.gameObject);
            key.enabled = false;
         }
    }

  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour
{
    
   void Start() {
        StartCoroutine(waitTime());
   }

   IEnumerator waitTime(){
    yield return new WaitForSecondsRealtime(3.5f);
    Instantiate(destroyedVersion, transform.position, transform.rotation);
    Destroy(gameObject);
   }
   

    public GameObject destroyedVersion;

    void OnMouseDown() {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }




}

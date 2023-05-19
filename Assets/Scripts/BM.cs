using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BM : MonoBehaviour
{
   
   GameObject obj1;
   GameObject obj2;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fall());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator fall()
    {   
        int i ;
        for(i = 0;i<343;i++){
             yield return new WaitForSecondsRealtime(0.05f);
             /*obj2 = GameObject.FindGameObjectsWithTag("2")[i];
             obj2.AddComponent<Rigidbody>();*/
             yield return new WaitForSecondsRealtime(0.05f);
             obj1 = GameObject.FindGameObjectsWithTag("1")[i];
             obj1.AddComponent<Rigidbody>();
             
        }
        /*int j;
        for(j=0;j<343;j++){
            yield return new WaitForSecondsRealtime(0.5f);
             obj2 = GameObject.FindGameObjectsWithTag("2")[j];
             obj2.AddComponent<Rigidbody>();

        }*/
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BM : MonoBehaviour
{
   
   GameObject obj1;
   GameObject obj2;
   public bool isTrigger;


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
        Physics.IgnoreLayerCollision(6,7, true);
        int i ;
        //GameObject[] arr = GameObject.FindGameObjectsWithTag("1");
        for(i = 0;i<transform.childCount;i++){
             yield return new WaitForSecondsRealtime(0.1f);
            // obj1 = arr[i];
            obj1 = transform.GetChild(i).gameObject;
             obj1.GetComponent<BoxCollider>().isTrigger = isTrigger;
             //obj1.Destroy(BoxCollider)
             obj1.AddComponent<Rigidbody>();
             obj1.GetComponent<Rigidbody>().AddTorque(Random.rotation.eulerAngles.normalized * 100);
            
        }
        /*int j;
        for(j=0;j<343;j++){
            yield return new WaitForSecondsRealtime(0.5f);
             obj2 = GameObject.FindGameObjectsWithTag("2")[j];
             obj2.AddComponent<Rigidbody>();

        }*/
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandalyeMovement : MonoBehaviour
{
    //public Transform[] way;

    //ParticleSystem kirari;
    public GameObject k1;
    
    float timer;
    public float waitTime;

    public Transform wayParent;
    int destination; // default olarak 0 olur
    public float sandalyeSpeed;

    public Transform player;
    public float closeToObject;

     private void Start() {
        // StartCoroutine(waitInTheBeginning());
        // kirari = GetComponentInChildren<ParticleSystem>();
        
        ParticuleClose();
    
  }

 
    
    IEnumerator waitInTheBeginning(){
      Debug.Log("Wait");
      yield return new WaitForSecondsRealtime(waitTime);
      Debug.Log("Wait");
        
        
    }


    void ParticuleClose(){
        k1.SetActive(false);
    }

    void Update()
    {

       //  transform.position = Vector3.MoveTowards(transform.position, way[destination].position, Time.deltaTime * sandalyeSpeed);
       // if(Vector3.Distance(transform.position, way[destination].position) < 0.1f && destination < way.Length - 1){
       //     destination++;
       //}

    timer += Time.deltaTime;
    if (timer > waitTime)
    {
       
    
       // Player ile ilerleme
      //if(Vector3.Distance(player.position, gameObject.transform.position) < closeToObject){  
        transform.position = Vector3.MoveTowards(transform.position,  wayParent.GetChild(destination).position, Time.deltaTime * sandalyeSpeed);
       if(Vector3.Distance(transform.position, wayParent.GetChild(destination).position) < 0.1f && destination < wayParent.childCount - 1){
           destination++;
       //}

            if(destination == 3){
            Debug.Log("Yep");
            k1.SetActive(true);
            
            /*
            var em = kirari.emission;
            em.rateOverTime = 0;
            */

        }

       } 
    } 

        
       
    
      
      
    } 


}

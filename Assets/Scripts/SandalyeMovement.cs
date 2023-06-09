using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandalyeMovement : MonoBehaviour
{
    //public Transform[] way;

    //ParticleSystem kirari;
    public GameObject k0;
    public GameObject k1;
    public GameObject k2;
    public GameObject k3;
    public GameObject k4; 
    
    float timer;
    public float waitTime;

    public Transform wayParent;
    int destination; // default olarak 0 olur
    public float sandalyeSpeed;

    public Transform player;
    public float closeToObject;
    bool didStart;

     private void Start() {
         StartCoroutine(waitInTheBeginning());
        // kirari = GetComponentInChildren<ParticleSystem>();
        
        ParticuleClose();
    
  }

 
    
    IEnumerator waitInTheBeginning(){
      Debug.Log("Wait");
      yield return new WaitForSecondsRealtime(4);
      didStart = true;
      Debug.Log("Wait");
        
        
    }


    void ParticuleClose(){
        k0.SetActive(false);
        k1.SetActive(false);
        k2.SetActive(false);
        k3.SetActive(false);
        k4.SetActive(false);
    }

    void Update()
    {

       //  transform.position = Vector3.MoveTowards(transform.position, way[destination].position, Time.deltaTime * sandalyeSpeed);
       // if(Vector3.Distance(transform.position, way[destination].position) < 0.1f && destination < way.Length - 1){
       //     destination++;
       //}

   
   
       if(!didStart)return;
    
       // Player ile ilerleme
      //if(Vector3.Distance(player.position, gameObject.transform.position) < closeToObject){  
        transform.position = Vector3.MoveTowards(transform.position,  wayParent.GetChild(destination).position, Time.deltaTime * sandalyeSpeed);
       bool didReach = Vector3.Distance(transform.position, wayParent.GetChild(destination).position) < 0.1f && destination < wayParent.childCount - 1;
       if(didReach){
         if(timer > waitTime){
            destination++;
            timer = 0;
         }
           timer += Time.deltaTime;
           
       //}
            if(destination == 1){
              k0.SetActive(true);
            }

            if(destination == 2){
              k1.SetActive(true);
            }

            if(destination == 3){
            Debug.Log("Yep");
            k2.SetActive(true);
            
            /*
            var em = kirari.emission;
            em.rateOverTime = 0;
            */

        }

          if(destination == 4){
            k3.SetActive(true);
          }

          if(destination == 5){
            k4.SetActive(true);
          }

       
    } 

        
       
    
      
      
    } 


}

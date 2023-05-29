using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandalyeMovement : MonoBehaviour
{
    //public Transform[] way;
    public Transform wayParent;
    int destination; // default olarak 0 olur
    public float sandalyeSpeed;

    public Transform player;
    public float closeToObject;

     private void Start() {
         StartCoroutine(waitInTheBeginning());
    
  }

    IEnumerator waitInTheBeginning(){
        yield return new WaitForSecondsRealtime(10f);
    }

    void Update()
    {

       //  transform.position = Vector3.MoveTowards(transform.position, way[destination].position, Time.deltaTime * sandalyeSpeed);
       // if(Vector3.Distance(transform.position, way[destination].position) < 0.1f && destination < way.Length - 1){
       //     destination++;
       //}

       // Player ile ilerleme
      //if(Vector3.Distance(player.position, gameObject.transform.position) < closeToObject){  
        transform.position = Vector3.MoveTowards(transform.position,  wayParent.GetChild(destination).position, Time.deltaTime * sandalyeSpeed);
       if(Vector3.Distance(transform.position, wayParent.GetChild(destination).position) < 0.1f && destination < wayParent.childCount - 1){
           destination++;
       //}

       

       }
      
    } 


}

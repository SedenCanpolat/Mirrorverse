using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
   public GameObject cube;

   public Door_slide1 top_left;
   public Door_slide1 top_right;
   public Door_slide1 bottom_left;
   public Door_slide1 bottom_right;
   public Door_slide1 belt_left;
   public Door_slide1 belt_right;
   public Door_slide1 back_top_left;
   public Door_slide1 back_top_right;
   public Door_slide1 back_bottom_left;
   public Door_slide1 back_bottom_right;
   public Door_slide1 back_belt_left;
   public Door_slide1 back_belt_right;

  void OnTriggerEnter(Collider  other){
        if(other.gameObject.tag == "Spinning"){
           top_left.l_fast();
           top_right.r_fast();
           bottom_left.l_fast();
           bottom_right.r_fast();
           belt_left.l_slow();
           belt_right.r_slow();
           back_top_left.l_fast();
           back_top_right.r_fast();
           back_bottom_left.l_fast();
           back_bottom_right.r_fast();
           back_belt_left.l_slow();
           back_belt_right.r_slow();
          
         
          //door.SetActive(false);
          //cube.SetActive(false);
        }
    }  











}

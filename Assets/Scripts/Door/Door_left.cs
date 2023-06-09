using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_left : MonoBehaviour
{ 
    public AudioSource open_sound;
    public Trigger trig;
    public Transform target;
    public Transform targett;
    public float t;
    public float speed;
    bool[] didPlaySound = new bool[2];

    void FixedUpdate()
    {
        if(trig.control == 1){
           Vector3 a = transform.position;
           Vector3 b = target.position;
           transform.position = Vector3.MoveTowards(a,Vector3.Lerp(a,b,t),speed);
           if(!didPlaySound[0]){
            open_sound.Play();
            didPlaySound[0] = true;
           }
    
        }
        else if(trig.control ==2){ 
           Vector3 c = transform.position;
           Vector3 d = targett.position;
           transform.position = Vector3.MoveTowards(c,Vector3.Lerp(c,d,t),speed);
           if(!didPlaySound[1]){
            open_sound.Play();
            didPlaySound[1] = true;
           }
        }
    }
}

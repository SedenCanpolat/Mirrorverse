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

    void FixedUpdate()
    {
        if(trig.control == 1){
           Vector3 a = transform.position;
           Vector3 b = target.position;
           transform.position = Vector3.MoveTowards(a,Vector3.Lerp(a,b,t),speed);
           //open_sound.Play();
        }
        else if(trig.control ==2){ 
           Vector3 c = transform.position;
           Vector3 d = targett.position;
           transform.position = Vector3.MoveTowards(c,Vector3.Lerp(c,d,t),speed);
           //open_sound.Play();
        }
    }
}

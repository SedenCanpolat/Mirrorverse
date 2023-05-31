using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Son : MonoBehaviour
{
    private int control = 0;
    public GameObject enter;
    //public GameObject exit;
    public Transform target;
    public float t;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if(control == 1){
           Vector3 a = transform.position;
           Vector3 b = target.position;
           transform.position = Vector3.MoveTowards(a,Vector3.Lerp(a,b,t),speed);

        }
    }

    void OnTriggerEnter(Collider  other){
        if(other.gameObject.tag == "Spinning"){
          enter.SetActive(false);
          control = 1;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_slide1 : MonoBehaviour
{
    public void l_fast()
    {
        transform.position = new Vector3(-1,0,0);
        transform.position = transform.position + new Vector3(0.01f,0,0) ;//* Time.deltaTime;

    }

    public void l_slow()
    {
        transform.position = new Vector3(-1,0,0);
        transform.position = transform.position + new Vector3(0.005f,0,0);
    }
    
    public void r_fast()
    {
        transform.position = new Vector3(1,0,0);
        transform.position = transform.position + new Vector3(0.001f,0,0);
    }
  
     public void r_slow()
    {
        transform.position = new Vector3(1,0,0);
        transform.position = transform.position + new Vector3(0.005f,0,0);
        
    }

}

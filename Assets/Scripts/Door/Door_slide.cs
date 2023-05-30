using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_slide : MonoBehaviour
{

    public void l_fast()
    {
        transform.position = new Vector3(-1,0,0);
        transform.position = transform.position + new Vector3(2f,0,0);
        print("aa");
    }

    public void l_slow()
    {
        transform.position = new Vector3(-1,0,0);
        transform.position = transform.position + new Vector3(100f,0,0);
        print("aa");
    }
    
    public void r_fast()
    {
        transform.position = new Vector3(1,0,0);
        transform.position = transform.position + new Vector3(2f,0,0);
        print("bb");
    }
  
     public void r_slow()
    {
        transform.position = new Vector3(1,0,0);
        transform.position = transform.position + new Vector3(10f,0,0);
        print("bb");
    }


}

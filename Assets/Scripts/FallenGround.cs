using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenGround : MonoBehaviour
{
    public float fallSecond;
    public void fall(){
         Destroy(this.gameObject, fallSecond);
    }


}

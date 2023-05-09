using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public GameObject f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fall1());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator fall1()
    {
        yield return new WaitForSecondsRealtime(1f);
        f.AddComponent<Rigidbody2D>();
    }
}

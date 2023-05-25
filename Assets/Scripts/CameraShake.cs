using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public IEnumerator Shake (float magnitude){

        Vector3 orginalPos = transform.localPosition;
        float elapsed = 0.0f;

        while(true){

            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 0.2f) * magnitude;

            transform.localPosition = new Vector3(x + orginalPos.x, y + orginalPos.y, orginalPos.z);
            elapsed += Time.deltaTime;
            yield return new WaitForSeconds(0.01f);
            transform.localPosition = orginalPos;
        }

    }

    private void Start() {
        StartCoroutine(Shake(.10f));
    }






}

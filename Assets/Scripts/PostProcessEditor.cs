using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class PostProcessEditor : MonoBehaviour
{
    private Volume volume;
    private ColorAdjustments colorCorrection;
    private ShadowsMidtonesHighlights midtonesHighlights;

    // Start is called before the first frame update
    void Start()
    {

    volume = GetComponent<Volume>();
    volume.profile.TryGet<ColorAdjustments>(out colorCorrection);
    volume.profile.TryGet<ShadowsMidtonesHighlights>(out midtonesHighlights);

    colorCorrection.colorFilter.value = Color.red;
    midtonesHighlights.highlights.value = new Vector4(255, 190, 190, 255);
        
    }

    // Update is called once per frame
    void Update()
    {
       // if(GetComponent<PlayerHealth>().healthBar.value <= 0.5){
            
       // }
        
    }
}

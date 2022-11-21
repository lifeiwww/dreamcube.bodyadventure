using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;



public class PostProcessing1 : MonoBehaviour
{
    // Start is called before the first frame update
    private float lerpTime = 5;
    private float currentLerpTime = 0;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
           Invoke("Darker",0);

    }

    void Darker()
    
     { currentLerpTime += Time.deltaTime;
    if(currentLerpTime >= lerpTime){
    currentLerpTime = lerpTime;
    }
      float Perc = currentLerpTime/lerpTime;
      GetComponent<Volume>().weight = Mathf.Lerp(1, 0, Perc);
    }
}

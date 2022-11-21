using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;



public class PostProcessing : MonoBehaviour
{
    // Start is called before the first frame update
    private float lerpTime = 3;
    private float currentLerpTime = 0;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Darker", 23);

    }

    void Darker()

    {
        currentLerpTime += Time.deltaTime;
        if (currentLerpTime >= lerpTime)
        {
            currentLerpTime = lerpTime;
        }
        float Perc = currentLerpTime / lerpTime;
        GetComponent<Volume>().weight = Mathf.Lerp(0, 1, Perc);
    }
}

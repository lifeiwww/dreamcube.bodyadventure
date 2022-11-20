using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;



public class PostProcessing : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      GetComponent<Volume>().weight = Mathf.Lerp(0, 1, .5f * Time.deltaTime);
    }
}

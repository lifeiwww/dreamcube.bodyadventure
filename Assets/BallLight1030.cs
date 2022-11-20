using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLight1030 : MonoBehaviour
{
    [SerializeField] private GameObject CapsuleBag;
  
    //[SerializeField] private float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //transform.up = (CapsuleBag.transform.position - transform.position) * -1;


        transform.LookAt(CapsuleBag.transform);
    }
}

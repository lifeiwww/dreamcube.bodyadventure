using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public int movementSpeed;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            GetComponent<Rigidbody>().AddForce(new Vector3(movementSpeed, 0, 0));



    }
}

using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class FloorTarget_MoveForward : MonoBehaviour
{
    //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    [SerializeField]
    private GameObject VisualObject;
    [SerializeField]
    private TextMeshPro StepNumberText;
    [SerializeField]
    private AudioSource AudioSource;
    [SerializeField]
    private GameObject MoveObject;
    public int movementSpeed;
    private int _timesHit;

    public void FloorTarget(GameObject visualObject, TextMeshPro stepNumberText)
    {
        VisualObject = visualObject;
        StepNumberText = stepNumberText;
    }

    private void OnTriggerEnter(Collider other)
    {
        // only be triggered by an object tagged as "Ball"
        if (other.gameObject.CompareTag("Ball"))
            Hit();
       
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
            notHit();
    }
    public void notHit()
    {

        MoveObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        var col0 = new Color(0.6f, 0.8f, 0.3f, 1);
        VisualObject.GetComponent<MeshRenderer>().material.color = col0;

    }

    public void Hit()
    {
        PositiveFeedback();
    }

    public void PositiveFeedback()
    {
        _timesHit++;

        // change color
        var col = new Color(0.8f, 0.7f, 0.6f, 1);
        VisualObject.GetComponent<MeshRenderer>().material.color = col;


        //var px = 0;
        // px = px + 1;
        //VisualObject.transform.position.x = px;


        //MoveObject.transform.position.z= 7.0f;
        MoveObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
        MoveObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, movementSpeed));

        // update text
        //StepNumberText.text = _timesHit.ToString("D2");

        //StepNumberText.fontSize = (Random.Range(20f, 30f));

        // make a sound
        //AudioSource.pitch = (Random.Range(0.6f, 1.2f));
       // AudioSource.Play();
    }
}

﻿using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;
using System.Collections;


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

    public void Hit()
    {
        PositiveFeedback();
    }

    public void PositiveFeedback()
    {
        _timesHit++;

        // change color
        var col = Random.ColorHSV(0, 1, 0.5f, 1, 1, 1);
        VisualObject.GetComponent<MeshRenderer>().material.color = col;

        //var px = 0;
       // px = px + 1;
        //VisualObject.transform.position.x = px;

        var pz = 13.0f;
        pz = pz - 0.5f;
        Vector3 temp = new Vector3(0,0,pz);
        MoveObject.transform.position = temp;
        //MoveObject.transform.position.z= 7.0f;


        // update text
        StepNumberText.text = _timesHit.ToString("D2");

        StepNumberText.fontSize = (Random.Range(20f, 30f));

        // make a sound
        AudioSource.pitch = (Random.Range(0.6f, 1.2f));
        AudioSource.Play();
    }
}

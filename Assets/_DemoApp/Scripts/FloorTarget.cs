using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;
using System.Collections;


public class FloorTarget : MonoBehaviour
{
    //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    [SerializeField]
    private GameObject VisualObject;
    [SerializeField]
    private TextMeshPro StepNumberText;
    [SerializeField]
    private AudioSource AudioSource;
  
    private int _timesHit;

    public float speed = 5f;
    Vector3 temp;

    public FloorTarget(GameObject visualObject, TextMeshPro stepNumberText)
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

        //if temp<0.2f
       // ScoreScript.scoreValue += 1;


        // change color
        var col = Random.ColorHSV(0, 1, 0.5f, 1, 1, 1);
        VisualObject.GetComponent<MeshRenderer>().material.color = col;

        //var px = 0;
       // px = px + 1;
        //VisualObject.transform.position.x = px;


        // update text
       // StepNumberText.text = _timesHit.ToString("D2");

       // StepNumberText.fontSize = (Random.Range(20f, 30f));



        // make a sound
        // AudioSource.pitch = (Random.Range(0.6f, 1.2f));
        //AudioSource.Play();

        //scale down
        temp = transform.localScale;

        temp.x -= 0.1f;
        temp.y -= 0.1f;
        temp.z -= 0.1f;

        transform.localScale = temp;


        if (temp.z<0.5f) {
            ScoreScript.scoreValue += 1;
            transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
        }



    }
    
}

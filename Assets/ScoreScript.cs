using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI score;

    public static int scoreValue = 0;
    //Text score;
    // Start is called before the first frame update
    void Start()
    {
      //  score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score:" + scoreValue;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOverScript : MonoBehaviour
{
    public Text text;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
        text.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

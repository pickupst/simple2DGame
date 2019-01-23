using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudScript : MonoBehaviour
{

    public Text scoreTect;

    float playerScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        playerScore += Time.deltaTime * 10;
        scoreTect.text = "Score: " + (int) playerScore;
        
    }

    public void IncScore(int amount)
    {

        playerScore += amount;

    }
}

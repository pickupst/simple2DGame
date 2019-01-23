using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupScript : MonoBehaviour
{
    HudScript hud;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            hud = GameObject.Find("Canvas").GetComponent<HudScript>();
            hud.IncScore(10);
            Destroy(this.gameObject);
        }
    }

}

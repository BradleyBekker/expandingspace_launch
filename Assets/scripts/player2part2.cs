using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2part2 : MonoBehaviour {

    // Use this for initialization
    public GameObject rocket;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player2")
        {
            rocket.GetComponent<P2rocket>().part2 = true;
            DestroyObject(gameObject);
        }
    }
}

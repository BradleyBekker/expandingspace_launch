using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1part2 : MonoBehaviour {

    public GameObject rocket;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player1")
        {
            rocket.GetComponent<P1rocket>().part2 = true;
            DestroyObject(gameObject);
        }
    }
}

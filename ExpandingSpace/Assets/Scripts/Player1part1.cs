using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1part1 : MonoBehaviour {
   public GameObject P1rocket;
    public GameObject P2rocket;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player1" && P1rocket.GetComponent<P1rocket>().part1 == false)
        {
            print("p1 got 1");
            P1rocket.GetComponent<P1rocket>().part1 = true;
            DestroyObject(gameObject);
        }
        if (collision.gameObject.tag == "player2" && P2rocket.GetComponent<P2rocket>().part1 == false)
        {
            print("p2 got 1");
            P2rocket.GetComponent<P2rocket>().part1 = true;
            DestroyObject(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1part1 : MonoBehaviour {
   public GameObject P1rocket;
    public GameObject P2rocket;
    [SerializeField] private Image Player1part;
    [SerializeField] private Image Player2part;

    private void Update()
    {
        Imagechecks();


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player1" && P1rocket.GetComponent<P1rocket>().part1 == false)
        {
            print("p1 got 1");
            P1rocket.GetComponent<P1rocket>().part1 = true;
            Player1part.enabled = true;
            DestroyObject(gameObject);
        }
        if (collision.gameObject.tag == "player2" && P2rocket.GetComponent<P2rocket>().part1 == false)
        {
            print("p2 got 1");
            P2rocket.GetComponent<P2rocket>().part1 = true;
            DestroyObject(gameObject);
            Player2part.enabled = true;

        }
    }

    void Imagechecks() {
        if (P1rocket.GetComponent<P1rocket>().part1 == true)
        {
            Player1part.enabled = true;
        }
        if (P1rocket.GetComponent<P1rocket>().part1 == false)
        {
            Player1part.enabled = false;
        }

        if (P2rocket.GetComponent<P2rocket>().part1 == true)
        {
            Player2part.enabled = true;
        }
        if (P2rocket.GetComponent<P2rocket>().part1 == false)
        {
            Player2part.enabled = false;
        }
    }
}

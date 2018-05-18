using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1part3 : MonoBehaviour {

    public GameObject rocket;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player1")
        {
            rocket.GetComponent<P1rocket>().part3 = true;
            DestroyObject(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2rocket : MonoBehaviour {
    public bool part1 = false;
    public bool part2 = false;
    public bool part3 = false;
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (part1 && part2 && part3 && collision.gameObject.tag == "player2")
        {
            print("p2 win");
        }
    }
}

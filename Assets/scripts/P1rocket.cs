using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1rocket : MonoBehaviour
{
    public bool part1 = false;
    public bool part2 = false;
    public bool part3 = false;
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (part1 && part2 && part3 && collision.gameObject.tag == "player1")
        {
            print("p1 win");
        }
    }
}

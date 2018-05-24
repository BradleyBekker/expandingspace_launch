using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            print("p1 win");
        }
    }
}

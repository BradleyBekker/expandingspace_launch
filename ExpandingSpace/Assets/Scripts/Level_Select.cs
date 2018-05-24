using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level_Select : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("start_button").GetComponentInChildren<Text>().text = "START";
    }
	
  public void Onclick()
    {
        SceneManager.UnloadScene("Menu");
        print("scene unloaded");
        SceneManager.LoadScene("ExpandingSpace");
        
    }
}

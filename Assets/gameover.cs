using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Awake()
    {
        Debug.Log("Let's end it all");
        StartCoroutine(EndThatShit(75));
    }

    IEnumerator EndThatShit(int nowait)
    {
        print("An ending comes...");
        yield return new WaitForSecondsRealtime(nowait);
        print("IT ENDS");
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour {

    public bool click;

	// Use this for initialization
	void Start () {
        GetComponent<TextMesh>().text = "Next Question";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        click = true;

    }

    void OnMouseUp()
    {
        click = false;

    }
}



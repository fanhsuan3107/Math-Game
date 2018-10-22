using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class option3 : MonoBehaviour
{

    public GameObject core;
    public GameObject option1;
    public GameObject option2;

    public bool isCorrect;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        int answer = core.GetComponent<GameController>().option;

        if (isCorrect)
        {
            GetComponent<TextMesh>().color = Color.green;
        }

        else
        {
            GetComponent<TextMesh>().color = Color.red;
           if (answer == 0)
            {
                option1.GetComponent<TextMesh>().color = new Color(17, 79, 47, 255);
            }

            else
            {
                option2.GetComponent<TextMesh>().color = new Color(17, 79, 47, 255);
            }
        }
    }
}

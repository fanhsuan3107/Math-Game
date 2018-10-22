using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class option1 : MonoBehaviour
{

    public GameObject core;
    public GameObject option2;
    public GameObject option3;


   public bool isCorrect;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnMouseDown()
    {
        int answer = core.GetComponent<GameController>().option;

        if (isCorrect)
        {
            GetComponent<TextMesh>().color = Color.green;
        }

        else
        {
            GetComponent<TextMesh>().color = Color.red;
           if (answer == 1)
            {
                option2.GetComponent<TextMesh>().color = new Color(17, 79, 47, 255);
            }
            else
            {
                option3.GetComponent<TextMesh>().color = new Color(17, 79, 47, 255);
            }
        }
    }
}
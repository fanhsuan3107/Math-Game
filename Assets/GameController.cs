﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int answer;
    public string randomOperator;

    public GameObject question;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;
    public GameObject next;

    public int option;

    // Use this for initialization
    void Start()
    {
        option = Random.Range(0, 3);
        GenerateQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        bool click = next.GetComponent<Next>().click;

        if (click)
        {
            option1.GetComponent<TextMesh>().color = Color.white;
            option2.GetComponent<TextMesh>().color = Color.white;
            option3.GetComponent<TextMesh>().color = Color.white;
            option = Random.Range(0, 3);
            GenerateQuestion();

        }
    }

    public void GenerateQuestion()
    {
        int a = Random.Range(0, 101);
        int b = Random.Range(0, 101);
        int operatorNumber = Random.Range(0, 3);

        if (operatorNumber == 0)
        {
            randomOperator = "+";
            answer = a + b;
        }
        else if (operatorNumber == 1)
        {
            randomOperator = "-";
            answer = a = b;
        }
        else
        {
            randomOperator = "*";
            answer = a * b;
        }

        //get component

        question.GetComponent<TextMesh>().text = a + " " + randomOperator + " " + b + "=?";


        if (option == 0)
        {
            option1.GetComponent<TextMesh>().text = answer.ToString();
            option2.GetComponent<TextMesh>().text = (answer + Random.Range(-5, 0)).ToString();
            option3.GetComponent<TextMesh>().text = (answer + 10).ToString();
            option1.GetComponent<option1>().isCorrect = true;
            option2.GetComponent<option2>().isCorrect = false;
            option3.GetComponent<option3>().isCorrect = false;
        }

        else if (option == 1)
        {
            option2.GetComponent<TextMesh>().text = answer.ToString();
            option3.GetComponent<TextMesh>().text = (answer + 10).ToString();
            option1.GetComponent<TextMesh>().text = (answer + Random.Range(-5, 0)).ToString();
            option2.GetComponent<option2>().isCorrect = true;
            option3.GetComponent<option3>().isCorrect = false;
            option1.GetComponent<option1>().isCorrect = false;

        }

        else
        {
            option3.GetComponent<TextMesh>().text = answer.ToString();
            option1.GetComponent<TextMesh>().text = (answer + Random.Range(-5, 0)).ToString();
            option2.GetComponent<TextMesh>().text = (answer + 10).ToString();
            option3.GetComponent<option3>().isCorrect = true;
            option1.GetComponent<option1>().isCorrect = false;
            option2.GetComponent<option2>().isCorrect = false;
        }
    }

}

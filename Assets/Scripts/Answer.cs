using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{
    public string answer;
    bool correct = false;
    public GameObject inputfield;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Text>().text.ToLower() == answer && !correct)
        {
            Gamemanager.correctAnswers++;
            inputfield.GetComponent<InputField>().enabled = false;
            correct = true;
        }
    }
}

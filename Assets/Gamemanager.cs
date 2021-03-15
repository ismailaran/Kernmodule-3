using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{

    float timer = 5;
    public float[] timerReset;
    public int[] threshold;
    int currentListLoc = 0;

    public static int correctAnswers = 0;
    public GameObject spawns;
    public GameObject popup;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (correctAnswers == threshold[currentListLoc + 1])
        {
            currentListLoc++;
        }

        if (currentListLoc > 0)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                timer = timerReset[currentListLoc];
                Instantiate(popup, spawns.transform.GetChild(Random.Range(0, spawns.transform.childCount)).transform);
                
            }
        }
        Debug.Log(timer);

    }
        
}

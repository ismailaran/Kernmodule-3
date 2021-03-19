using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager1 : MonoBehaviour
{

    float timer = 5;
    public float[] timerReset;
    public int[] threshold;
    int currentListLoc = 0;

    public static int correctAnswers = 0;
    public GameObject spawns;
    public GameObject popup;

    public GameObject canvasScroller;
    float canvasScrollerHeight;

    void Start()
    {
        canvasScrollerHeight = canvasScroller.transform.position.y;
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
    }

    public void StartGame()
    {
        StartCoroutine(scrollDown());
        Debug.Log("button pressed");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator scrollDown()
    {
        Debug.Log("Coroutine started");
        float lerpDistance = 0f;
        while (canvasScroller.transform.position.y > (canvasScrollerHeight - Screen.height))
        {
            lerpDistance += Time.deltaTime;
            canvasScroller.transform.position = new Vector3(canvasScroller.transform.position.x, Mathf.Lerp(canvasScrollerHeight, canvasScrollerHeight + Screen.height, lerpDistance), canvasScroller.transform.position.z);
            Debug.Log("scrolling");

            yield return null;
        }


        yield return new WaitForSeconds(3f);
    }
        
    void PlayClassroomNoises()
    {

    }
}

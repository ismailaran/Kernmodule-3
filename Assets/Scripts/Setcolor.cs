using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setcolor : MonoBehaviour
{
    public Sprite[] image;
    void Start()
    {
        //GetComponent<Image>().color = Random.ColorHSV();
        GetComponent<Image>().sprite = image[Random.Range(0, image.Length - 1)];
        transform.parent = transform.parent.parent;
        transform.localScale = new Vector3(2, 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

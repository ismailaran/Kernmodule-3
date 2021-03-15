using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesboek : MonoBehaviour
{
    public Sprite[] pagina;
    private int page;
    void Start()
    {
        GetComponent<Image>().sprite = pagina[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextPage()
    {
        if (page < pagina.Length - 1)page++;
        GetComponent<Image>().sprite = pagina[page];
    }

    public void previousPage()
    {
        if (page > 0) page--;
        GetComponent<Image>().sprite = pagina[page];
    }
}

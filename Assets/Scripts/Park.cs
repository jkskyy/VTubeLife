using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Park : MonoBehaviour
{
    public GameObject blank, hover, map, parkScreen;

    void OnMouseOver()
    {
        blank.SetActive(false);
        hover.SetActive(true);
    }
    void OnMouseExit()
    {
        hover.SetActive(false);
        blank.SetActive(true);
    }
    void OnMouseDown()
    {
        map.SetActive(false);
        //parkScreen.SetActive(true);
    }
}

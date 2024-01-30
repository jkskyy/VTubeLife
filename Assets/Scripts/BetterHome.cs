using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BetterHome : MonoBehaviour
{
    public GameObject blank, hover, map, betterHomeScreen;

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
        //betterHomeScreen.SetActive(true);
    }
}


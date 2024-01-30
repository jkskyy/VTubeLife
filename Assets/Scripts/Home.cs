using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public GameObject blank, hover, map, homeScreen, mapLeft, mapRight, stats;
    public Camera mainCamera;

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
        mapLeft.SetActive(false);
        mapRight.SetActive(false);
        homeScreen.transform.position = new Vector3(mainCamera.transform.position.x, mainCamera.transform.position.y, homeScreen.transform.position.z);
        homeScreen.SetActive(true);
        stats.SetActive(false);
        
    }

    public void homeClose()
    {
        homeScreen.SetActive(false);
        mapLeft.SetActive(true);
        mapRight.SetActive(true);
        map.SetActive(true);
        stats.SetActive(true);
    }
}

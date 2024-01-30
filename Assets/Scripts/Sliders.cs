using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliders : MonoBehaviour
{
    public PlayerData PlayerData;
    void Start()
    {
        var dictionary = PlayerData.StatsData();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideStats : MonoBehaviour
{
    public GameObject hidden, shown;
    public void showhidestats()
    {
        hidden.SetActive(!hidden.activeSelf);
        shown.SetActive(!shown.activeSelf);
    }
}

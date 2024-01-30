using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRightLogic : MonoBehaviour
{
    public GameObject mapRight;
    public Camera mapCamera;

    void Update()
    {
        if (mapCamera.transform.position.x == 2) mapRight.GetComponent<BoxCollider2D>().enabled = false;
        else mapRight.GetComponent<BoxCollider2D>().enabled = true;
    }
    void OnMouseOver()
    {
        mapCamera.transform.position = new Vector3(Mathf.Clamp(mapCamera.transform.position.x + 0.05f, -2.5f, 2f), mapCamera.transform.position.y, mapCamera.transform.position.z);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLogic : MonoBehaviour
{
    public GameObject FirstBackground, SecondBackground, fence1, fence2, panel = null;
    void Start()
    {
        Invoke("Panel", 1);
    }
    void Update()
    {
        if (SecondBackground.transform.position.x < -21.76)
        {
            SecondBackground.transform.position = new Vector2(21.7f, SecondBackground.transform.position.y);
        }

        if (FirstBackground.transform.position.x < -21.76)
        {
            FirstBackground.transform.position = new Vector2(21.7f, FirstBackground.transform.position.y);
        }

        if (fence1.transform.position.x < -21.29)
        {
            fence1.transform.position = new Vector2(43.9f, fence1.transform.position.y);
        }

        if (fence2.transform.position.x < -21.29)
        {
            fence2.transform.position = new Vector2(43.9f, fence2.transform.position.y);
        }

        FirstBackground.transform.position = new Vector2(FirstBackground.transform.position.x - 0.005f, FirstBackground.transform.position.y);
        SecondBackground.transform.position = new Vector2(SecondBackground.transform.position.x - 0.005f, SecondBackground.transform.position.y);
        fence1.transform.position = new Vector2(fence1.transform.position.x - 0.005f, fence1.transform.position.y);
        fence2.transform.position = new Vector2(fence2.transform.position.x - 0.005f, fence2.transform.position.y);
    }

    public IEnumerator firstBG()
    {
        while (FirstBackground)
        {
            yield return new WaitForSeconds(0.0008f);
            FirstBackground.transform.position = new Vector2(FirstBackground.transform.position.x - 0.005f, FirstBackground.transform.position.y);

        }
        yield return 0;
    }

    public void Panel()
    {
        if(panel != null) panel.SetActive(true);
    }
}

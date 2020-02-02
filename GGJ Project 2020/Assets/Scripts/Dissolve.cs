using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    public GameObject transitionStart;
    public GameObject transitionEnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transitionStart.GetComponent<SpriteRenderer>().color = Color.Lerp(transitionStart.GetComponent<SpriteRenderer>().color, new Color(0, 0, 0, 0), Time.deltaTime/3);
        transitionEnd.GetComponent<SpriteRenderer>().color = Color.Lerp(transitionEnd.GetComponent<SpriteRenderer>().color, new Color(1, 1, 1, 1), Time.deltaTime/3);
    }
}

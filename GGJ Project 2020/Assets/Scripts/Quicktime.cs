using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quicktime : MonoBehaviour
{
    public Slider quicktimeSlider;
    bool go = true;
    bool lower = false;
    bool raise = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            go = false;
        }

        if (go)
        {
            if (raise == true && lower == false)
            {
                quicktimeSlider.value += 10 * Time.deltaTime;
                if (quicktimeSlider.value == quicktimeSlider.maxValue)
                {
                    raise = false;
                    lower = true;
                }
            }
            if (raise == false && lower == true)
            {
                quicktimeSlider.value -= 10 * Time.deltaTime;
                if (quicktimeSlider.value == quicktimeSlider.minValue)
                {
                    lower = false;
                    raise = true;
                }
            }
        }
    }

    private void OnMouseDown()
    {
        raise = false;
        lower = false;
    }
}

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

    bool success = false;
    float minSuccess = -1.0f;
    float maxSuccess = 1.0f;

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
            if(quicktimeSlider.value >= minSuccess && quicktimeSlider.value <= maxSuccess)
            {
                Debug.Log("Success");
                success = true;
            }
            else
            {

                Debug.Log("Failure");
            }
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

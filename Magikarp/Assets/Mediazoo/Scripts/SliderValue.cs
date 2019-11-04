using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
    private Slider test;

    void Awake()
    {
        test = this.gameObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(test.value);
    }

    public void OnValueChanged(float newValue)
    {
        //test.value = newValue;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatBar : MonoBehaviour {
    private Image content;
    private float currentFill;
    public float MyMaxValue { get; set; }
    private float currentValue;
    private float startmanaTime = 1.0f;
    private float manaTime = 1.0f;

    public float MyCurrentValue
    {
        get
        {
            return currentValue;
        }

        set
        {
            if(value > MyMaxValue)
            {
                currentValue = MyMaxValue;
            }
            else if(value < 0)
            {
                currentValue = 0;
            }
            else
            {
                currentValue = value;
            }
            currentFill = currentValue / MyMaxValue;
        }
    }

    

	// Use this for initialization
	void Start () {
       
        content = GetComponent<Image>();
        
	}
	
	// Update is called once per frame
	void Update () {
        if(currentFill < MyMaxValue)
        {
            manaTime -= Time.deltaTime;
            if (manaTime < 0)
            {
                MyCurrentValue += 1;
                manaTime = startmanaTime;
            }
        }
        content.fillAmount = currentFill;
	}

    public void initialized(float currentValue, float maxValue)
    {
        MyMaxValue = maxValue;
        MyCurrentValue = currentValue;
    }


}

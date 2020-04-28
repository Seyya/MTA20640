﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gas_meter : MonoBehaviour
{
    public TextMeshProUGUI gas_text;
    private int gas_total = 300;
    private int gas = 300;


    // used for testing the gas checker function
    /*void Start()
    {
        
        for (int i = 0; i < 1; i++)
        {

            gasChecker(2);

        }
    }*/

        //Could also change id to string so it correlates to loop, method or whatever 
    public void gasChecker(int id) //id refers to if it is a loop, method or if-statement
    {
        if (id == 0) // 0 is a method raw
        {
            gas -= 20;
            gas_text.text = "Gas" + "\n" + gas + "/" + gas_total;
        }
        else if(id == 1) // 1 is a method inside a loop
        {
            gas -= 10;
            gas_text.text = "Gas" + "\n" + gas + "/" + gas_total;
        }
        else if(id == 2) // 2 is a method inside an if-statement
        {
            gas -= 15;
            gas_text.text = "Gas" + "\n" + gas + "/" + gas_total;
        }
    }
}

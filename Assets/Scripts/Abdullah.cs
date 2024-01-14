using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abdullah : MonoBehaviour
{
    public float number1;
    public float number2;
    public string operation;

    void OnEnable()
    {
        if(operation == "+")
        {
            Debug.Log(number1 + number2);
        }

        else if (operation == "-")
        {
            Debug.Log(number1 - number2);
        }

        else if (operation == "*")
        {
            Debug.Log(number1 * number2);
        }

        if (operation == "/")
        {
            Debug.Log(number1 / number2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

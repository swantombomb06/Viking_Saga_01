using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberCounter : MonoBehaviour
{
    public int targetValue = 8;
    public int currentValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        while (currentValue <= targetValue) {
            Debug.Log("Number is " + currentValue);
            currentValue++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

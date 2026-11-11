using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenOddChecker : MonoBehaviour
{
    public int numberToCheck = 5;

    // Start is called before the first frame update
    void Start()
    {
        if (numberToCheck % 2 == 0)
        {
            Debug.Log("Number is even");
        }
        else
        {
            Debug.Log("Number is odd");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

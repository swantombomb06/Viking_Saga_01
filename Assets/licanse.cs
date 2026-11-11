using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class licanse : MonoBehaviour
{

    string driverName;
    int age;
    bool passed;

    void CheckLicanse()
    {
        if (passed && age >= 17)
        {
            Debug.Log(driverName + " can get full driving license");
        }
        else if (age >= 17)
        {
            Debug.Log(driverName + " is old enough to get a provosiona driving licanse");
        }
        else
        {
            Debug.Log(driverName + " old is under 17 , can't get a driving licanse");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        driverName = "Max";
        age = 16;
        passed = true;

        CheckLicanse();
    }

    private void Update()
    {
        //APP AGE
        if (Input.GetKeyDown(KeyCode.W))
        {
            age++;
            Debug.Log(driverName + " is " + age + " age ");
            //CheckLicanse();

        }
        //DOWN
        if (Input.GetKeyDown(KeyCode.S)) 
        {
            age--;

            if (age <= 0)
            {
                age = 0;
            }

            Debug.Log(driverName + " is " + age + " age ");
            //CheckLicanse();

        };

        //START CHECKING
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CheckLicanse();
        }
    }
}

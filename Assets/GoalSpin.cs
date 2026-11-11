using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalSpin : MonoBehaviour
{
    public float rotSpeed = 50;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left, rotSpeed * Time.deltaTime);
    }
}

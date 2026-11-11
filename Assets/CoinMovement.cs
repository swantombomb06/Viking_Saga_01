using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    public float moveSpeed = 1;
    public float amplitude = 0.2f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalMovement = Mathf.Sin(Time.time * moveSpeed) * amplitude;

        Vector3 newPos = startPos + Vector3.up * verticalMovement;

        transform.position = newPos;
    }
}

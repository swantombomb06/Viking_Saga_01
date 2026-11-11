using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameIterator : MonoBehaviour
{
    private string[] names = { "Alice", "Bob", "Charlie", "David", "Eve" };

    // Start is called before the first frame update
    void Start()
    {
        foreach (string name in names) { 
            Debug.Log("Name " + name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(100f * Time.deltaTime, 0f, 0f);
    }
}

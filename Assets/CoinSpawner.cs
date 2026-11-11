using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject[] coins;

    public float gap;
    public int rowQty;
    public int columnQty;
    private int previousColumnQty;
    private int previousRowQty;
    private float previousGap;

    // Start is called before the first frame update
    void Start()
    {
        //rowQty = 0;
        //columnQty = 0;

        previousGap = gap;
        previousRowQty = rowQty;
        previousColumnQty = rowQty;

        Debug.Log("QTY ROW: " + rowQty + "QTY COL: " + columnQty);


        putCoins();
    }

    // Update is called once per frame
    void putCoins()
    {
        int totalCoinsQty = rowQty * columnQty;
        coins = new GameObject[totalCoinsQty];

        int index = 0;

        for (int i = 0; i < rowQty; i++) 
        {
            for (int j = 0; j < columnQty; j++)
            {

                //coins[index] = coinPrefab;

                Vector3 pos = new Vector3(transform.position.x + i + (gap * i), 1, transform.position.z + j + (gap * j));

                coins[index] = Instantiate(
                coinPrefab,
                pos,
                Quaternion.identity
                );

                //Instantiate(coins[i], pos, Quaternion.identity);

                index++;
            }
        }
    }

    private void resetCoin()
    {
       for(int i = 0;i < coins.Length;i++)
        {
            Destroy(coins[i]);
        }
    }

    void Update()
    {
        if (rowQty != previousRowQty 
            || columnQty != previousColumnQty 
            || previousGap != gap)
        {
            // Remember the new value
            previousRowQty = rowQty;
            previousColumnQty = columnQty;
            previousGap = gap;

            resetCoin();
            putCoins();
        }
    }
}

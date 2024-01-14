using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCreation : MonoBehaviour
{
    public GameObject coin;
    private int count = 0;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(createCoins());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator createCoins()
    {
        yield return new WaitForSeconds(1.5f);

        while(count < 10)
        {
            Instantiate(coin, new Vector3(Random.Range(minX, maxX), 1, Random.Range(minY, maxY)), Quaternion.identity);

            count++;
            yield return new WaitForSeconds(1.0f);
        }
    }
}

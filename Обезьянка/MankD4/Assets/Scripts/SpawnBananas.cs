using System.Collections;
using UnityEngine;

public class SpawnBananas : MonoBehaviour
{
    public GameObject bananas;
    public GameObject cocount;
    public GameObject candy;
    public GameObject banan;
   
    int i = 0, k=0;
    void Start ()
    {
        StartCoroutine (Spawn ());
    }
  IEnumerator Spawn ()
    {
        while (!Player.lose)
        {
            i++;
            yield return new WaitForSeconds(0.8f);
            if (i==5 || i==10 || i==15)
            {               
                Instantiate(cocount, new Vector2(Random.Range(-2.2f, 2.2f), 5.9f), Quaternion.identity);
            
                continue;
            }
            if (i == 4 || i == 8 || i == 12)
            {
                Instantiate(bananas, new Vector2(Random.Range(-2.2f, 2.2f), 5.9f), Quaternion.identity);

             
                continue;
            }
            if (i == 17)
            {
                Instantiate(candy, new Vector2(Random.Range(-2.2f, 2.2f), 5.9f), Quaternion.identity);
                i = 0;
                continue;
            }

            Instantiate(banan, new Vector2(Random.Range(-2.2f, 2.2f), 5.9f), Quaternion.identity);
        }
    }
}

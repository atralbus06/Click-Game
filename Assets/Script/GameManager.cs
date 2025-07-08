using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Monster[] slimes;
    [SerializeField] float damage;
    Monster curSlime;

    public void SpawnSlime()
    {
        int spawnIndex = UnityEngine.Random.Range(0, slimes.Length);
        GameObject newSlime = Instantiate(slimes[spawnIndex].gameObject);
        curSlime = newSlime.GetComponent<Monster>();
    }

    void Update()
    {
        if (curSlime == null)
        {
            SpawnSlime();
        }
    }

    public void HitSlime()
    {
        if (curSlime != null)
        {
            curSlime.OnHit(damage);
        }
    }
}

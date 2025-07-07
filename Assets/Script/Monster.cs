using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] float maxHp;
    float curHp;

    bool isDead = false;

    void Awake()
    {
        curHp = maxHp;
    }

    public void OnHit(float damage)
    {
        curHp -= damage;
        if (curHp <= 0)
        {
            curHp = 0;
            isDead = true;
        }
        Debug.Log("Slime Hit! Current Hp : " + curHp);

        if (isDead)
        {
            Debug.Log("Slime is Dead");
            Destroy(gameObject, 1.5f);
        }

    }
}

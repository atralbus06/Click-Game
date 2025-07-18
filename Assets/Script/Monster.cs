using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    [SerializeField] HpBar hpBar;
    [SerializeField] Text nameText;

    [SerializeField] string monsterName;
    [SerializeField] float maxHp;
    float curHp;

    bool isDead = false;
    Animator anim;

    void Awake()
    {
        curHp = maxHp;
        nameText.text = monsterName;
        anim = GetComponent<Animator>();
    }

    public void OnHit(float damage)
    {
        curHp -= damage;
        if (curHp <= 0)
        {
            curHp = 0;
            isDead = true;
        }
        anim.SetTrigger("Hit");
        Debug.Log("Slime Hit! Current Hp : " + curHp);
        hpBar.ChangeHpBarAmount(curHp / maxHp);

        if (isDead)
        {
            Debug.Log("Slime is Dead");
            anim.SetTrigger("Death");
            hpBar.Destroy();
            Destroy(nameText);
            Destroy(gameObject, 1.5f);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAttack : MonoBehaviour
{

    [SerializeField] int damage;
    [SerializeField] float frequency;
    [SerializeField] GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Attack", 2, frequency);
    }

    void Attack()
    {
        Life targetLife = target.GetComponent<Life>();
        if (targetLife != null)
        {
            targetLife.GetHit(damage);
        }
    }

}

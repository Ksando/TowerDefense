using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerProjectileScr : MonoBehaviour
{

    Transform target;
    TowerProjectile selfProjectile;
    public Tower selfTower;
    GameControllerScr gcs;
    public float basicDamage;
    Multipliers multi;
    private void Start()
    {
        gcs = FindObjectOfType<GameControllerScr>();
        multi = GameObject.Find("Main Camera").GetComponent<Multipliers>();
        selfProjectile = gcs.AllProjectiles[selfTower.type];
        basicDamage = selfProjectile.damage;
        GetComponent<SpriteRenderer>().sprite = selfProjectile.Spr;
    }
    void Update()
    {
        Move();
    }

    public void SetTarget(Transform enemy)
    {
        target = enemy;
    }

    private void Move()
    {
        if (target != null)
        {
            if (Vector2.Distance(transform.position, target.position) < .1f)
            {
                Hit();
            }
            else
            {
                Vector2 dir = target.position - transform.position;
                transform.Translate(dir.normalized * Time.deltaTime * selfProjectile.speed);
            }
        }
        else
            Destroy(gameObject);
    }

    void Hit()
    {
        switch (selfTower.type)
        {
            case (int)TowerType.FIRST_TOWER:
                target.GetComponent<Enemy>().TakeDamage(selfProjectile.damage * multi.getDamageMulti(gameObject.tag));
                break;
            case (int)TowerType.SECOND_TOWER:
                target.GetComponent<Enemy>().StartSlow(3);
                target.GetComponent<Enemy>().TakeDamage(selfProjectile.damage * multi.getDamageMulti(gameObject.tag));
                break;
            case (int)TowerType.THIRD_TOWER:
                target.GetComponent<Enemy>().TakeDamage(selfProjectile.damage * multi.getDamageMulti(gameObject.tag));
                break;
            case (int)TowerType.FOURTH_TOWER:
                target.GetComponent<Enemy>().TakeDamage(selfProjectile.damage * multi.getDamageMulti(gameObject.tag));
                break;
        }

        Destroy(gameObject);
    }

}
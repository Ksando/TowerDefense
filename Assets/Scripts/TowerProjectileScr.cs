using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerProjectileScr : MonoBehaviour
{

    Transform target;
    TowerProjectile selfProjectile;
    public Tower selfTower;
    public int level;
    GameControllerScr gcs;
    public float basicDamage;
    Multipliers multi;
    private void Start()
    {
        gcs = FindObjectOfType<GameControllerScr>();
        multi = GameObject.Find("Main Camera").GetComponent<Multipliers>();
        if (level == 0)
            selfProjectile = gcs.AllProjectiles[selfTower.type];
        else if (level == 1)
            selfProjectile = gcs.SecondProjectiles[selfTower.type];
        else if (level == 2)
            selfProjectile = gcs.ThirdProjectiles[selfTower.type];
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
                target.GetComponent<Enemy>().TakeDamage(selfProjectile.damage * multi.getDamageMulti("DefaultTower"));
                break;
            case (int)TowerType.SECOND_TOWER:
                target.GetComponent<Enemy>().StartSlow(3);
                target.GetComponent<Enemy>().TakeDamage(selfProjectile.damage * multi.getDamageMulti("SlowingTower"));
                break;
            case (int)TowerType.THIRD_TOWER:
                target.GetComponent<Enemy>().TakeDamage(selfProjectile.damage * multi.getDamageMulti("RapidTower"));
                break;
            case (int)TowerType.FOURTH_TOWER:
                target.GetComponent<Enemy>().TakeDamage(selfProjectile.damage * multi.getDamageMulti("SniperTower"));
                break;
            case (int)TowerType.FIFTH_TOWER:
                string[] enemyTags =
                 {
                     "DefaultMutant",
                     "FastMutant",
                     "HeavyMutant",
                     "BossMutant"
                 };

                foreach (string tag in enemyTags)
                {
                    GameObject[] enemy = GameObject.FindGameObjectsWithTag(tag);
                    for (int i = 0; i < enemy.Length; i++)
                    {
                        float CurrDistance = Vector2.Distance(transform.position, enemy[i].transform.position);

                        if (CurrDistance <= 1.5f)
                        {
                            enemy[i].GetComponent<Enemy>().TakeDamage(selfProjectile.damage * multi.getDamageMulti("AoeTower"));
                        }
                    }
                }
                break;
        }

        Destroy(gameObject);
    }

}
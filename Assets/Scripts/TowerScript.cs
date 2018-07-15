using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{

    public GameObject Projectile;
    Tower selfTower;
    public TowerType selfType;
    GameControllerScr gcs;

    string[] enemyTags =
             {
                 "DefaultMutant",
                 "FastMutant",
                 "HeavyMutant",
                 "BossMutant"
             };
    private void Start()
    {
        gcs = FindObjectOfType<GameControllerScr>();

        selfTower = gcs.AllTowers[(int)selfType];
        GetComponent<SpriteRenderer>().sprite = selfTower.Spr;

        InvokeRepeating("SearchTarget", 0, .1f);
    }

    private void Update()
    {
        if (selfTower.CurrCooldown > 0)
            selfTower.CurrCooldown -= Time.deltaTime;
    }

    bool CanShoot()
    {
        if (selfTower.CurrCooldown <= 0)
            return true;
        return false;
    }

    void SearchTarget()
    {
        if (CanShoot())
        {
            Transform nearestEnemy = null;
            float nearestEnemyDistance = Mathf.Infinity;

            foreach (string tag in enemyTags)
            {
                GameObject[] enemy = GameObject.FindGameObjectsWithTag(tag);
                for (int i = 0; i < enemy.Length; i++)
                {
                    float CurrDistance = Vector2.Distance(transform.position, enemy[i].transform.position);

                    if (CurrDistance < nearestEnemyDistance && CurrDistance <= selfTower.Range)
                    {
                        nearestEnemy = enemy[i].transform;
                        nearestEnemyDistance = CurrDistance;
                    }
                }
            }
            if (nearestEnemy != null)
                Shoot(nearestEnemy);
        }
    }
    void Shoot(Transform enemy)
    {
        selfTower.CurrCooldown = selfTower.Cooldown;
        GameObject proj = Instantiate(Projectile);
        proj.GetComponent<TowerProjectileScr>().selfTower = selfTower;
        proj.transform.position = transform.position;
        proj.GetComponent<TowerProjectileScr>().SetTarget(enemy);
    }

}
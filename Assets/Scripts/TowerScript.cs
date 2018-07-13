using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{

    public GameObject Projectile;
    Tower selfTower;
    public TowerType selfType;
    GameControllerScr gcs;

    private void Start()
    {
        gcs = FindObjectOfType<GameControllerScr>();

        selfTower = gcs.AllTowers[(int)selfType];
        GetComponent<SpriteRenderer>().sprite = selfTower.Spr;
    }

    private void Update()
    {
        if (CanShoot())
            SearchTarget();

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
        Transform nearestEnemy = null;
        float nearestEnemyDistance = Mathf.Infinity;

        foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("DefaultMutant"))
        {
            float CurrDistance = Vector2.Distance(transform.position, enemy.transform.position);

                if (CurrDistance < nearestEnemyDistance && CurrDistance <= selfTower.Range)
            {
                nearestEnemy = enemy.transform;
                nearestEnemyDistance = CurrDistance;
            }
        }
        if (nearestEnemy != null)
            Shoot(nearestEnemy);
        
    }
    void Shoot(Transform enemy)
    {
        selfTower.CurrCooldown = selfTower.Cooldown;
        GameObject proj = Instantiate(Projectile);
        proj.GetComponent<TowerProjectileScr>().selfProjectile = gcs.AllProjectiles[(int)selfType];
        proj.transform.position = transform.position;
        proj.GetComponent<TowerProjectileScr>().SetTarget(enemy);
    }

}
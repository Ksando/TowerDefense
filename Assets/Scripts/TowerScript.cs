using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{
    Settings sets;
    public AudioSource audio;
    public GameObject Projectile;
    public List<Tower> selfTower = new List<Tower>();
    public TowerType selfType;
    GameControllerScr gcs;
    Multipliers multi;

    public int level = 0;

    string[] enemyTags =
             {
                 "DefaultMutant",
                 "FastMutant",
                 "HeavyMutant",
                 "BossMutant"
             };
    private void Start()
    {
        sets = GameObject.Find("Settings").GetComponent<Settings>();
        audio = GetComponent<AudioSource>();
        gcs = FindObjectOfType<GameControllerScr>();
        multi = GameObject.Find("Main Camera").GetComponent<Multipliers>();
        selfTower.Add(gcs.AllTowers[(int)selfType]);
        selfTower.Add(gcs.SecondTowers[(int)selfType]);
        selfTower.Add(gcs.ThirdTowers[(int)selfType]);
        GetComponent<SpriteRenderer>().sprite = selfTower[level].Spr;
        InvokeRepeating("SearchTarget", 0, .1f);
    }

    private void Update()
    {
        audio.volume = sets.soundsVolume;
        if (selfTower[level].CurrCooldown > 0f)
            selfTower[level].CurrCooldown -= Time.deltaTime;
    }

    bool CanShoot()
    {
        if (selfTower[level].CurrCooldown <= 0f)
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

                    if (CurrDistance < nearestEnemyDistance && CurrDistance <= selfTower[level].Range)
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
        audio.Play();
        selfTower[level].CurrCooldown = selfTower[level].Cooldown * multi.getReloadMulti(gameObject.tag);
        GameObject proj = Instantiate(Projectile);
        proj.GetComponent<TowerProjectileScr>().selfTower = selfTower[level];
        proj.GetComponent<TowerProjectileScr>().level = level;
        proj.transform.position = transform.position;
        proj.GetComponent<TowerProjectileScr>().SetTarget(enemy);
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower
{
    public int type;
    public float Range, Cooldown, CurrCooldown = 0;
    public Sprite Spr;
    
    public Tower(int type, float Range, float cd, string path)
    {
        this.type = type;
        this.Range = Range;
        Cooldown = cd;
        Spr = Resources.Load<Sprite>(path);
    }
}

public class TowerProjectile
{
    public float speed;
    public float damage;
    public Sprite Spr;

    public TowerProjectile(float speed, float dmg, string path)
    {
        this.speed = speed;
        damage = dmg;
        Spr = Resources.Load<Sprite>(path);
    }

}

public enum TowerType
{
    FIRST_TOWER, //Slow
    SECOND_TOWER,//Simple
    THIRD_TOWER,//Fast
    FOURTH_TOWER//Sniper
}



public class GameControllerScr : MonoBehaviour
{

    public List<Tower> AllTowers = new List<Tower>();
    public List<TowerProjectile> AllProjectiles = new List<TowerProjectile>();
    private Multipliers multi;
    private void Awake()
    {
        multi = GameObject.Find("Main UI").GetComponent<Multipliers>();
        AllTowers.Add(new Tower(0, 3, 1 * multi.getReloadMulti("TowerSlow"), "TowerSprites /DiTower"));
        AllTowers.Add(new Tower(1, 3 , 3 * multi.getReloadMulti("TowerSimple"), "TowerSprites/SiTower"));
        AllTowers.Add(new Tower(2, 2 , .7f * multi.getReloadMulti("TowerFast"), "TowerSprites/FiTower"));
        AllTowers.Add(new Tower(3, 5, 5 * multi.getReloadMulti("TowerSniper"), "TowerSprites/SniTower"));

        AllProjectiles.Add(new TowerProjectile(10, 5 * multi.getDamageMulti("TowerSlow"), "ProjectilesSprites/DiProjectile"));
        AllProjectiles.Add(new TowerProjectile(10, 5 * multi.getDamageMulti("TowerSimple"), "ProjectilesSprites/SiProjectile"));
        AllProjectiles.Add(new TowerProjectile(40, 2 * multi.getDamageMulti("TowerFast"), "ProjectilesSprites/FiProjectile"));
        AllProjectiles.Add(new TowerProjectile(10, 10 * multi.getDamageMulti("TowerSniper"), "ProjectilesSprites/SniProjectile"));
    }
}

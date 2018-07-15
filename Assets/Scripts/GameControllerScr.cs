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
    FIRST_TOWER, 
    SECOND_TOWER,
    THIRD_TOWER,
    FOURTH_TOWER
}



public class GameControllerScr : MonoBehaviour
{

    public List<Tower> AllTowers = new List<Tower>();
    public List<TowerProjectile> AllProjectiles = new List<TowerProjectile>();
    private void Awake()
    {
        AllTowers.Add(new Tower(0, 3, 1, "TowerSprites/DiTower"));
        AllTowers.Add(new Tower(1, 3 , 3, "TowerSprites/SiTower"));
        AllTowers.Add(new Tower(2, 2 , .7f, "TowerSprites/FiTower"));
        AllTowers.Add(new Tower(3, 5, 5, "TowerSprites/SniTower"));

        AllProjectiles.Add(new TowerProjectile(10, 5, "ProjectilesSprites/DiProjectile"));
        AllProjectiles.Add(new TowerProjectile(10, 5, "ProjectilesSprites/SiProjectile"));
        AllProjectiles.Add(new TowerProjectile(40, 2, "ProjectilesSprites/FiProjectile"));
        AllProjectiles.Add(new TowerProjectile(10, 10, "ProjectilesSprites/SniProjectile"));
    }
}

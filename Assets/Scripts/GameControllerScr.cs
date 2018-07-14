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
    public int damage;
    public Sprite Spr;

    public TowerProjectile(float speed, int dmg, string path)
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
        AllTowers.Add(new Tower(1, 4, 3, "TowerSprites/SiTower"));
        AllTowers.Add(new Tower(2, 5, 6, "TowerSprites/FiTower"));
        AllTowers.Add(new Tower(3, 3, .7f, "TowerSprites/SniTower"));

        AllProjectiles.Add(new TowerProjectile(10, 20, "ProjectilesSprites/DiProjectile"));
        AllProjectiles.Add(new TowerProjectile(0, 20, "ProjectilesSprites/SiProjectile"));
        AllProjectiles.Add(new TowerProjectile(40, 20, "ProjectilesSprites/FiProjectile"));
        AllProjectiles.Add(new TowerProjectile(10, 20, "ProjectilesSprites/SniProjectile"));
    }
}

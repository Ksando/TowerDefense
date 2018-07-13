using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower
{
    public float Range, Cooldown, CurrCooldown = 0;
    public Sprite Spr;

    public Tower(float Range, float cd, string path)
    {
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
    SECOND_TOWER
}



public class GameControllerScr : MonoBehaviour {

    public List<Tower> AllTowers = new List<Tower>();
    public List<TowerProjectile> AllProjectiles = new List<TowerProjectile>();

    private void Awake()
    {
        AllTowers.Add(new Tower(3, 1, "TowerSprites/DiTower"));
        AllTowers.Add(new Tower(4, 3, "TowerSprites/SiTower"));

        AllProjectiles.Add(new TowerProjectile(10, 20, "ProjectilesSprites/DiProjectile"));
        AllProjectiles.Add(new TowerProjectile(5, 2, "ProjectilesSprites/SiProjectile"));
    }
}

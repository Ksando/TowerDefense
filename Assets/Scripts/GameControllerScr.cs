using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower
{
    public int type, price;
    public float Range, Cooldown, CurrCooldown = 0;
    public Sprite Spr;
    
    public Tower(int type, int price, float Range, float cd, string path)
    {
        this.type = type;
        this.price = price;
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
    FIRST_TOWER,        // DefaultTower - обычная
    SECOND_TOWER,       // SlowingTower - замедляющая
    THIRD_TOWER,        // FastTower    - пулеметная
    FOURTH_TOWER,       // SniperTower  - снайперская
    FIFTH_TOWER         // AoeTower     - ракетная
}



public class GameControllerScr : MonoBehaviour
{

    public List<Tower> AllTowers = new List<Tower>();
    public List<Tower> SecondTowers = new List<Tower>();
    public List<Tower> ThirdTowers = new List<Tower>();

    public List<TowerProjectile> AllProjectiles = new List<TowerProjectile>();
    public List<TowerProjectile> SecondProjectiles = new List<TowerProjectile>();
    public List<TowerProjectile> ThirdProjectiles = new List<TowerProjectile>();
    private void Awake()
    {   
        //Tower(type, price, range, cooldown, spritepath)
        AllTowers.Add(new Tower(0, 50, 3, 1, "TowerSprites/DiTower"));
        AllTowers.Add(new Tower(1, 100, 4, 3, "TowerSprites/SiTower"));
        AllTowers.Add(new Tower(2, 90, 2, .7f, "TowerSprites/FiTower"));
        AllTowers.Add(new Tower(3, 120, 5, 5, "TowerSprites/SniTower"));
        AllTowers.Add(new Tower(4, 100, 3, 4, "TowerSprites/AoeTower"));

        SecondTowers.Add(new Tower(0, 80, 3, 1, "TowerSprites/DiTower"));
        SecondTowers.Add(new Tower(1, 150, 4, 2, "TowerSprites/SiTower"));
        SecondTowers.Add(new Tower(2, 150, 2, .6f, "TowerSprites/FiTower"));
        SecondTowers.Add(new Tower(3, 260, 5, 5, "TowerSprites/SniTower"));
        SecondTowers.Add(new Tower(4, 200, 3, 4, "TowerSprites/AoeTower"));

        ThirdTowers.Add(new Tower(0, 110, 4, .8f, "TowerSprites/DiTower"));
        ThirdTowers.Add(new Tower(1, 200, 5, 2, "TowerSprites/SiTower"));
        ThirdTowers.Add(new Tower(2, 200, 3, .5f, "TowerSprites/FiTower"));
        ThirdTowers.Add(new Tower(3, 400, 5, 5, "TowerSprites/SniTower"));
        ThirdTowers.Add(new Tower(4, 300, 3, 4, "TowerSprites/AoeTower"));

        //TowerProjectile(speed, damage, spritepath)
        AllProjectiles.Add(new TowerProjectile(10, 4, "ProjectilesSprites/DiProjectile"));
        AllProjectiles.Add(new TowerProjectile(10, 0, "ProjectilesSprites/SiProjectile"));
        AllProjectiles.Add(new TowerProjectile(10, 2, "ProjectilesSprites/FiProjectile"));
        AllProjectiles.Add(new TowerProjectile(10, 8, "ProjectilesSprites/SniProjectile"));
        AllProjectiles.Add(new TowerProjectile(5, 4, "ProjectilesSprites/AoeProjectile"));

        AllProjectiles.Add(new TowerProjectile(10, 6, "ProjectilesSprites/DiProjectile"));
        AllProjectiles.Add(new TowerProjectile(10, 0, "ProjectilesSprites/SiProjectile"));
        AllProjectiles.Add(new TowerProjectile(10, 3, "ProjectilesSprites/FiProjectile"));
        AllProjectiles.Add(new TowerProjectile(15, 12, "ProjectilesSprites/SniProjectile"));
        AllProjectiles.Add(new TowerProjectile(5, 6, "ProjectilesSprites/AoeProjectile"));

        AllProjectiles.Add(new TowerProjectile(10, 7, "ProjectilesSprites/DiProjectile"));
        AllProjectiles.Add(new TowerProjectile(10, 0, "ProjectilesSprites/SiProjectile"));
        AllProjectiles.Add(new TowerProjectile(10, 4, "ProjectilesSprites/FiProjectile"));
        AllProjectiles.Add(new TowerProjectile(15, 14, "ProjectilesSprites/SniProjectile"));
        AllProjectiles.Add(new TowerProjectile(5, 6, "ProjectilesSprites/AoeProjectile"));
    }
}

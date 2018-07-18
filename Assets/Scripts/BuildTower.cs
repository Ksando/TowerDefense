using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BuildTower : MonoBehaviour {

    public GameObject towerSimple;
    public GameObject towerSlow;
    public GameObject towerSniper;
    public GameObject towerAOE;
    public GameObject towerFast;
    public GameObject buildMenu;
    public GameObject upgradeMenu;

	public bool canOpen = true;
    Transform tilePosition;

    float costMod = 1;

    // Use this for initialization
    void Start () {
        costMod = GetComponent<Abillity>().getBuyMulti();
        GameObject.Find("Simple").GetComponent<Text>().text = (int)(50f * costMod) + "$";
        GameObject.Find("Slow").GetComponent<Text>().text = (int)(100f * costMod) + "$";
        GameObject.Find("Sniper").GetComponent<Text>().text = (int)(100f * costMod) + "$";
        GameObject.Find("AOE").GetComponent<Text>().text = (int)(120f * costMod) + "$";
        GameObject.Find("Fast").GetComponent<Text>().text = (int)(90f * costMod) + "$";
        buildMenu.SetActive(false);
        upgradeMenu.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(!canOpen)
		{
			return;
		}
        else if(Input.GetMouseButton(0))
        {
            RaycastHit2D rayHit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (rayHit.transform != null)
            {
                if (rayHit.transform.tag == "DefaultTower" || rayHit.transform.tag == "SlowingTower" || rayHit.transform.tag == "SniperTower" || rayHit.transform.tag == "AoeTower" || rayHit.transform.tag == "RapidTower")
                {
                    upgradeMenu.SetActive(true);
                    buildMenu.SetActive(false);
                }
                else if (rayHit.transform.tag == "TowerPlacement")
                {
                    buildMenu.SetActive(true);
                    upgradeMenu.SetActive(false);
                }
                if(tilePosition != null)
                    tilePosition.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                tilePosition = rayHit.transform;
                tilePosition.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
            }
            else if (tilePosition != null && Input.mousePosition.x * (1920f / Screen.width) >= 1570) 
            {
                return;
            }
            else
            {
                tilePosition.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                tilePosition = null;
                buildMenu.SetActive(false);
                upgradeMenu.SetActive(false);
            }
        }
	}

    public void buildTower(int t)
    {
        buildMenu.SetActive(false);
		switch (t)
        {
            case 1:
                if (GetComponent<Player>().buySomething((int)(50f * costMod)))  
                    Instantiate(towerSimple, tilePosition.position + new Vector3(0, 0, -1), tilePosition.rotation);
                break;
            case 2:
                if (GetComponent<Player>().buySomething((int)(100f * costMod))) 
                    Instantiate(towerSlow, tilePosition.position + new Vector3(0, 0, -1), tilePosition.rotation);
                break;
            case 3:
                if (GetComponent<Player>().buySomething((int)(100f * costMod))) 
                    Instantiate(towerSniper, tilePosition.position + new Vector3(0, 0, -1), tilePosition.rotation);
                break;
            case 4:
                if (GetComponent<Player>().buySomething((int)(120f * costMod))) 
                    Instantiate(towerAOE, tilePosition.position + new Vector3(0, 0, -1), tilePosition.rotation);
                break;
            case 5:
                if (GetComponent<Player>().buySomething((int)(90f * costMod))) 
                    Instantiate(towerFast, tilePosition.position + new Vector3(0, 0, -1), tilePosition.rotation);
                break;
            default:
                break;
        }
		tilePosition.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
		tilePosition = null;
    }

	public void upgradeTower()
	{

	}

	public void sellTower()
	{

	}
}

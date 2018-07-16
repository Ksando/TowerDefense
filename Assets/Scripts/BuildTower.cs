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
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButton(0))
        {
            RaycastHit2D rayHit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            //Debug.Log(mousePos + " || " + Input.mousePosition.x * (1920f/Screen.width));
            if (rayHit.transform != null && rayHit.transform.tag == "TowerPlacement")
            {
                /*if (EventSystem.current.IsPointerOverGameObject())
                    return;*/

                buildMenu.SetActive(true);

                tilePosition = rayHit.transform;
            }
            else if (tilePosition != null && Input.mousePosition.x * (1920f / Screen.width) >= 1570) 
            {
                return;
            }
            else
            {
                buildMenu.SetActive(false);
            }
        }
	}

    public void buildTower(int t)
    {
        buildMenu.SetActive(false);
        switch(t)
        {
            case 1:
                if (GetComponent<Player>().buySomething((int)(50f * costMod)))  
                    Instantiate(towerSimple, tilePosition.position, tilePosition.rotation);
                break;
            case 2:
                if (GetComponent<Player>().buySomething((int)(100f * costMod))) 
                    Instantiate(towerSlow, tilePosition.position, tilePosition.rotation);
                break;
            case 3:
                if (GetComponent<Player>().buySomething((int)(100f * costMod))) 
                    Instantiate(towerSniper, tilePosition.position, tilePosition.rotation);
                break;
            case 4:
                if (GetComponent<Player>().buySomething((int)(120f * costMod))) 
                    Instantiate(towerAOE, tilePosition.position, tilePosition.rotation);
                break;
            case 5:
                if (GetComponent<Player>().buySomething((int)(90f * costMod))) 
                    Instantiate(towerFast, tilePosition.position, tilePosition.rotation);
                break;
            default:
                break;
        }
    }
}

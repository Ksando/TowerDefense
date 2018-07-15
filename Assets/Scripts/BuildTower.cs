using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButton(0))
        {
            RaycastHit2D rayHit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            //Debug.Log(mousePos + " || " + Input.mousePosition.x * (1920f/Screen.width));
            if (rayHit.transform != null && rayHit.transform.tag == "TowerPlacement")
            {
                if (EventSystem.current.IsPointerOverGameObject())
                    return;
                
                buildMenu.SetActive(true);
                Vector2 menuPos = Input.mousePosition;
                if (Input.mousePosition.x * (1920f / Screen.width) < 280)
                    menuPos.x = 280 / (1920f / Screen.width);
                else if (Input.mousePosition.x * (1920f / Screen.width) > 1640)
                    menuPos.x = 1640 / (1920f / Screen.width);

                if (Input.mousePosition.y * (1080f / Screen.height) > 820)
                    menuPos.y = 920 / (1080f / Screen.height);
                else if (Input.mousePosition.x * (1920f / Screen.width) < 260)
                    menuPos.y = 160 / (1080f / Screen.height);
                buildMenu.transform.position = menuPos;

                tilePosition = rayHit.transform;
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
                if (GetComponent<Player>().buySomething((int)(50 * costMod)))  
                    Instantiate(towerSimple, tilePosition.position, tilePosition.rotation);
<<<<<<< HEAD
=======

>>>>>>> 1a5553a7b3ad02e8f423ff9173909941fc4de558
                break;
            case 2:
                if (GetComponent<Player>().buySomething((int)(100 * costMod))) 
                    Instantiate(towerSlow, tilePosition.position, tilePosition.rotation);
                break;
            case 3:
                if (GetComponent<Player>().buySomething((int)(100 * costMod))) 
                    Instantiate(towerAOE, tilePosition.position, tilePosition.rotation);
                break;
            case 4:
                if (GetComponent<Player>().buySomething((int)(120 * costMod))) 
                    Instantiate(towerSniper, tilePosition.position, tilePosition.rotation);
                break;
            case 5:
                if (GetComponent<Player>().buySomething((int)(90 * costMod))) 
                    Instantiate(towerFast, tilePosition.position, tilePosition.rotation);
                break;
            default:
                break;
        }
    }
}

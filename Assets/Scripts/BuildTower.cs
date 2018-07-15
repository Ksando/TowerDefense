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

	// Use this for initialization
	void Start () {
        
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

                if (Input.mousePosition.y * (1080f / Screen.height) > 920)
                    menuPos.y = 920 / (1080f / Screen.height);
                else if (Input.mousePosition.x * (1920f / Screen.width) < 160)
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
        switch(t)
        {
            case 1:
                buildMenu.SetActive(false);
                if(GetComponent<Player>().buySomething(100))
                    Instantiate(towerSimple, tilePosition.position, tilePosition.rotation);
                
                    
                break;
            default:
                break;
        }
    }
}

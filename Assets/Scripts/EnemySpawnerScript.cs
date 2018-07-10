//Sasha
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawnerScript : MonoBehaviour
{

    public GameObject[] enemyPrefab;
    public GameObject[] enemy;
    Vector2 whereToSpawn = new Vector2();
    public int HowManyToSpawn;
    //int counter = 0;
    //float nextSpawn = 0.0f;
    public GameObject canvasObject;

	// Use this for initialization
	void Start () {
        enemy = new GameObject[enemyPrefab.Length];
        for (int i = 0; i < enemyPrefab.Length; i++)
        {
            whereToSpawn = new Vector2(21.36f + i, 11.37f);
            enemy[i] = Instantiate(enemyPrefab[i], whereToSpawn, Quaternion.identity) as GameObject;
          //  enemy[i].transform.SetParent(canvasObject.transform, false);
            enemy[i].name = ("enemy" + i);
        }
	}



    // Update is called once per frame
    void Update () {

        //    if (counter < HowManyToSpawn & Time.time > nextSpawn)
        //   {
        //      counter++;
        //    nextSpawn = Time.time + 0;
        //  GameObject enemy1 = Instantiate(enemy, whereToSpawn, Quaternion.identity) as GameObject;
        //enemy1.transform.SetParent(canvasObject.transform, false);

        // }
       // for (int i = 0; i < enemyPrefab.Length; i++)
       // {
        //    if (HealthbarScript.health == 0)
        //    {
        //        Destroy(enemy[i]);
        //    }
      //  }

	}

}

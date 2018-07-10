//Sasha
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Base : MonoBehaviour {

    public float BaseHealth = 100;
    public Image BaseHealthBar;
    public float maxBaseHealth = 100f;



    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()  {
      
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            Debug.Log("PRIVET");
            if (BaseHealth > 0)
            {
                Debug.Log("YAVOSHLA");
                StartCoroutine("WaitingFunction111");
            }

        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }


    IEnumerator WaitingFunction111()
    {
        while (BaseHealth > 0)
        {
            Debug.Log("BASE TAGGG");
            BaseHealth -= 10;
            BaseHealthBar.fillAmount = BaseHealth / maxBaseHealth;
            print(Time.time);
            yield return new WaitForSecondsRealtime(5);
        }
        if (BaseHealth <= 0)
        {
            Die();
        }
    }
}

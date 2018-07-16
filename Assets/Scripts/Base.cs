//Sasha
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Base : MonoBehaviour {

    public float BaseHealth = 100;
    public Image BaseHealthBar;
    public float maxBaseHealth = 100f;
    private string className;



    // Use this for initialization
    void Start ()
    {
	}

    // Update is called once per frame
    void Update()
    {
     
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "DefaultMutant")
        {
            if (BaseHealth > 0)
            {
                StartCoroutine(WaitingFunction111(1));
            }
        }
        if (col.gameObject.tag == "FastMutant")
        {
            if (BaseHealth > 0)
            {
                StartCoroutine(WaitingFunction111(1));
            }
        }
        if (col.gameObject.tag == "HeavyMutant")
        {
            if (BaseHealth > 0)
            {
                StartCoroutine(WaitingFunction111(2));
            }
        }
        if (col.gameObject.tag == "BossMutant")
        {
            if (BaseHealth > 0)
            {
                StartCoroutine(WaitingFunction111(10));
            }
        }

    }

    private void Die()
    {
        Destroy(gameObject);
    }


    IEnumerator WaitingFunction111(int dmg)
    {
        while (BaseHealth > 0 && gameObject != null)
        {
            Debug.Log("Mutant just hit the base with damage:");
            Debug.Log(dmg);
            BaseHealth -= dmg;
            BaseHealthBar.fillAmount = BaseHealth / maxBaseHealth;
            yield return new WaitForSecondsRealtime(5);
        }
        if (BaseHealth <= 0)
        {
            Die();
        }
    }
}

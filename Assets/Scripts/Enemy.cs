//Sasha
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public float health = 100;
    float startSpeed = 2f;
    public Image healthBar;
    public float maxHealth = 100f;
    public float speed = 2f;
    private void Start()
    {

    }

    private void update()
    {
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        healthBar.fillAmount = health / maxHealth;
        CheckIsAlive();
    }

    void CheckIsAlive()
    {
        if (health <= 0)
            Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "tower")
        {
            Debug.Log("TAGGG");
            if (health > 0)
            {
                //decrease enemy health
                health -= 10;
                healthBar.fillAmount = health / maxHealth;
                if (health <= 0)
                {
                    Die();
                }
            }
        }
    }


    private void Die()
    {
        Destroy(gameObject);
    }

    public void StartSlow(float duration, float slowValue)
    {
        speed = startSpeed;
        StopCoroutine("GetSlow");
        StartCoroutine(GetSlow(duration, slowValue));
    }
    IEnumerator GetSlow(float duration, float slowValue)
    {
        speed -= slowValue;
        yield return new WaitForSeconds(duration);
        speed = startSpeed;
    }
}

//Sasha
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public float health = 100;
    public Image healthBar;
    public float maxHealth = 100f;
    private void Start()
    {

    }

    public void TakeDamage(int damage)
    {
        health -= damage;
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
}

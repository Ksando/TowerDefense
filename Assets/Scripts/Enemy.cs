//Sasha
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public float health = 100;
    float startSpeed;
    public Image healthBar;
    public float maxHealth = 100f;
    public float speed = 2f;
    Player player;
    Multipliers multi;
    private void Start()
    {
        multi = GameObject.Find("Main Camera").GetComponent<Multipliers>();
        startSpeed = speed;
        player = GameObject.Find("Main Camera").GetComponent<Player>();
    }

    private void update()
    {
        speed = startSpeed * multi.getSpeedMulti(gameObject.tag);
        Debug.Log(gameObject.tag);
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        healthBar.fillAmount = health / maxHealth;
        CheckIsAlive();
    }

    void CheckIsAlive()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            player.addMoney(50);
        }
     }


    public void StartSlow(float duration)
    {
        speed = startSpeed;
        StopCoroutine("GetSlow");
        StartCoroutine(GetSlow(duration));
    }
    IEnumerator GetSlow(float duration)
    {
        speed -= speed/2;
        yield return new WaitForSeconds(duration);
        speed = startSpeed;
    }
}

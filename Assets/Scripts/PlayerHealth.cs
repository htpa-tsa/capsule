using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour{

    public GameManager manager;
    public Slider healthBar;
    public float health = 100f;

    private void Start()
    {
        healthBar.maxValue = health;
        healthBar.value = health;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            takeDamage(10f);
        }
    }

    public void takeDamage(float amnt)
    {
        health -= amnt;
        if (health <= 0f)
        {
            manager.GameOver();
        }
        float _h = Mathf.Clamp(health, 0, 100f);
        healthBar.value = _h;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        takeDamage(10);
    }
}
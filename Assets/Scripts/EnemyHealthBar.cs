using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyHealthBar : MonoBehaviour {
	
	Animator anim;

	public float startSpeed = 10f;

	[HideInInspector]
	public float speed;

	public float startHealth = 100;
	private float health;

	public int worth = 50;

	public GameObject deathEffect;

	[Header("Unity Stuff")]
	public Image healthBar;

	private bool isDead = false;

	void Start ()
	{
		speed = startSpeed;
		health = startHealth;
	}

        private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Melee")
        TakeDamage(10);
    }

	public void TakeDamage (float amount)
	{
		health -= amount;

		healthBar.fillAmount = health / startHealth;

		if (health <= 0 && !isDead)
		{
			Die();
		}
	}

	public void Slow (float pct)
	{
		speed = startSpeed * (1f - pct);
	}

	void Die ()
	{
        Destroy(gameObject);
		isDead = true;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		anim.SetBool("FadeOut",true);
		
	}

}

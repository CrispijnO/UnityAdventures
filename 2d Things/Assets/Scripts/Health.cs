using UnityEngine;

public class Health : MonoBehaviour {

    public float maxHp = 5;
    public float currentHp = 3;
    public float damage = 0.75f;

    void Start() {
        FindObjectOfType<GameManager>().checkPlayerHealth();
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.tag == "Enemy") {
            float enemyDamage = collision.gameObject.GetComponent<Enemy>().damage;
            takingDmg(enemyDamage);
            if (currentHp == 0) {
                FindObjectOfType<GameManager>().GameOver();
                Destroy(gameObject);
                Time.timeScale = 0;
            }
        }
    }

    public void takingDmg(float x) {

        currentHp-=x;
    }
}
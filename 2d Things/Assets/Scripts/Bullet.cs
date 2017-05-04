using UnityEngine;

public class Bullet : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Wall") {

            Destroy(gameObject, 0.05f);
        }
        if (collision.tag == "Enemy") {
            float enemyHp = collision.GetComponent<Enemy>().hp;
            float playerDamage = FindObjectOfType<Health>().damage;
            enemyHp = enemyHp - playerDamage;
            Destroy(gameObject);
            collision.GetComponent<Enemy>().hp = enemyHp;

            if (enemyHp <= 0) {
                Destroy(collision.gameObject);
            }
        }
    }
}

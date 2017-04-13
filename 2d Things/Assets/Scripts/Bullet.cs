using UnityEngine;

public class Bullet : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Wall") {

            Destroy(gameObject, 0.05f);
        }
        if (collision.tag == "Enemy") {
            collision.GetComponent<EnemyHealth>().hp--;
            Destroy(gameObject);
            if (collision.GetComponent<EnemyHealth>().hp == 0) {
                Destroy(collision.gameObject);
            }
        }
    }
}

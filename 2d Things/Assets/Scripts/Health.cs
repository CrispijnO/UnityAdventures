using UnityEngine;

public class Health : MonoBehaviour {

    public int hp = 6;

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.tag == "Enemy") {
            takingDmg(1);
            if (hp == 0) {
                FindObjectOfType<GameManager>().GameOver();
                Debug.Log(gameObject.tag);
                Destroy(gameObject);
                Time.timeScale = 0;
            }
        }
    }

    public void takingDmg(int x) {

        hp-=x;
    }
}
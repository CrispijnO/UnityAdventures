using UnityEngine;
using UnityEngine.UI;

public class bombPickUp : MonoBehaviour {

    public Text bombText;

    void OnCollisionEnter2D(Collision2D collision) {

        if(collision.collider.name == "Player") {
            float bombs = int.Parse(bombText.text);
            bombs++;
            bombText.text = bombs.ToString();
            Destroy(gameObject);
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class PickupPickup : MonoBehaviour {

    public Text scoreText;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Player")
        {
            float score = int.Parse(scoreText.text);
            score++;
            scoreText.text = score.ToString();
            Destroy(gameObject);
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class bombUpPick : MonoBehaviour {

    public GameObject bombPickup;
    public Text bombText;

    void Start() {
        InvokeRepeating("SpawnBomb", 1f, 5f);
    }

    void SpawnBomb () {
        GameObject bomb = Instantiate(bombPickup, new Vector3(Random.Range(-7f, 7f), Random.Range(-5f, 5f), -1), Quaternion.identity) as GameObject;
        bomb.GetComponent<bombPickUp>().bombText = bombText;
        Destroy(bomb, 5f);
    }
}

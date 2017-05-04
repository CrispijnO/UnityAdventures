using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject fullHeart;
    
    public void GameOver() {
        Debug.Log("DEAD");
    }

    public void checkPlayerHealth() { //check playerhealth and set the right amount in the UI
        float currentPlayerHealth = FindObjectOfType<Health>().currentHp;
        float maxPlayerHealth = FindObjectOfType<Health>().maxHp;

        Transform hpBar = GameObject.Find("HealthBar").transform;

        for (int i = 0; i < maxPlayerHealth; i++) {
            Instantiate(fullHeart, GameObject.Find("HealthBar").transform);
            Vector3 temp = new Vector3(70, 0, 0);
            //hpBar.position = hpBar.transform.position + temp;
            Debug.Log(GameObject.Find("HealthBar").transform.position);
        }
    }
}

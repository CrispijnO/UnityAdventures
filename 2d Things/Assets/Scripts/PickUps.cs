using UnityEngine;
using UnityEngine.UI;

public class PickUps : MonoBehaviour {

    public GameObject PickUp;
    public Text scoreText;
    
	void Start () {
        InvokeRepeating("SpawnPickUp", 1.0f, 5f);
	}
	
	void SpawnPickUp () {
        GameObject pickUp = Instantiate(PickUp, new Vector3(Random.Range(-7f, 7f), Random.Range(-5f, 5f), -1), Quaternion.identity) as GameObject;
        pickUp.GetComponent<PickupPickup>().scoreText = scoreText;
        Destroy(pickUp, 5.0f);
    }
}

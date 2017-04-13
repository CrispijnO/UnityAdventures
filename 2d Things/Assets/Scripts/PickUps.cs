using UnityEngine;
using UnityEngine.UI;

public class PickUps : MonoBehaviour {

    public Transform PickUp;
    public Text scoreText;
    
	void Start () {
        InvokeRepeating("SpawnPickUp", 1.0f, 5f);
	}
	
	void SpawnPickUp () {
        Transform coinTransform = Instantiate(PickUp, new Vector3(Random.Range(-7f, 7f), Random.Range(-5f, 5f), -1), Quaternion.identity) as Transform;
        GameObject coin = coinTransform.gameObject;
        coin.GetComponent<PickupPickup>().scoreText = scoreText;
        Destroy(coin, 5.0f);
    }
}

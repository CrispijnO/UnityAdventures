using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float Speed;
	
	void FixedUpdate () {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * Speed;
        float y = Input.GetAxis("Vertical") * Time.fixedDeltaTime * Speed;
        
        transform.Translate(0, y, 0);
        transform.Translate(x, 0, 0);
    }
}

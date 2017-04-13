using UnityEngine;

public class Shooting : MonoBehaviour {
    
    public GameObject Shot;
    public float projectileSpeed = 5f;
    public float shootDelay = 0.5f;
    private float nextFire = 0.0f;
    Vector2 projectileDirection;
    Transform firePoint;
    GameObject Bullet;


    void Update() {

        firePoint = GetComponentInChildren<Transform>();
        Shoot();
    }

    void Shoot() {

        if (Input.GetKey("up")) {
            projectileDirection = new Vector2(0, 1);
            Fire();
        }
        if (Input.GetKey("down")) {
            projectileDirection = new Vector2(0, -1);
            Fire();
        }
        if (Input.GetKey("right")) {
            projectileDirection = new Vector2(1, 0);
            Fire();
        }
        if (Input.GetKey("left")) {
            projectileDirection = new Vector2(-1, 0);
            Fire();
        }

    }

    void Fire() {
        if (Time.time > nextFire) {

            nextFire = Time.time + shootDelay;
            Bullet = Instantiate(Shot, firePoint.transform.position, firePoint.transform.rotation);
            Bullet.GetComponent<Rigidbody2D>().velocity = (projectileDirection * projectileSpeed);
            Destroy(Bullet, 3f);
        }

    }
}
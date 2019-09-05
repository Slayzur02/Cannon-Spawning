using UnityEngine;
using System.Collections;

public class Bullet_spawn : MonoBehaviour
{ 
    public GameObject bullet;
    public Transform spawnpoint;
    public float bulletSpeed;
    public Vector3 direction;

    void Start() {
    direction = new Vector3(0.0f, 0.0f, Random.Range(160.0f, 200f));
    bulletSpeed = Random.Range(4.0f, 8.0f);
    StartCoroutine(Countdown1());
    }

    private IEnumerator Countdown1() {
    while(true) {
        yield return new WaitForSeconds(0.7f); 
        Instantiate(bullet, spawnpoint.position, spawnpoint.rotation);
    }
    }

    void OnBecameInvisible() {
         Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour {
    public GameObject asteroidPrefab;
    public GameObject asteroidAux;
    public BorderTrigger left;
    public BorderTrigger right;
    public BorderTrigger top;
    public BorderTrigger bottom;
    public int amountOfAsteroids = 5 ;
    float timer;
    int aux;
    public float spawnRate = 2;
    // Use this for initialization
	void Start () {
        timer = 0f;
        aux = 1;
    }

    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;
        if (timer >= spawnRate && aux <= amountOfAsteroids) {
            timer = 0f;
            asteroidAux = Instantiate(asteroidPrefab, new Vector3 (Random.Range(left.transform.position.x,right.transform.position.x),0.5f,Random.Range(bottom.transform.position.z,top.transform.position.z)), new Quaternion()) ;
            asteroidAux.GetComponent<Rigidbody>().AddForce(Random.Range(-150, 150), 0, Random.Range(-150, 150));
            aux++;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {
    public float speed = 5f;
    public Transform canonDirection;
    public GameObject bulletPrefab;
    
    Rigidbody rb;
    // Use this for initialization
    void Start() {
        Debug.Log("ika");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(new Vector3(0, -1, 0));
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(new Vector3(0, 1, 0));
        }

        if (Input.GetKey(KeyCode.UpArrow)) {
            //transform.position += transform.forward * speed * Time.deltaTime;
            rb.AddForce(transform.forward * speed);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject bulletAux = Instantiate(bulletPrefab, canonDirection.position, canonDirection.rotation);
            bulletAux.GetComponent<Rigidbody>().AddForce(transform.forward * 100);
        }
      
    }

    private void OnTriggerEnter(Collider other) {
        //Debug.Log("Trigger");
    }
}

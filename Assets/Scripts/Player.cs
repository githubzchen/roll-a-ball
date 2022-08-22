using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
 
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            Debug.Log("Collectable collected!");
            GameObject.Destroy(other.gameObject);
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        // Movement input
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        

        //rb.AddForce(transform.forward, ForceMode.Impulse);
        rb.AddForce(direction, ForceMode.Impulse);
    }
}

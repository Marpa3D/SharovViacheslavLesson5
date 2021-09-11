using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    // Скачки сферы для наблюдения персонажем

    [SerializeField] private Rigidbody rb;
    [SerializeField] private float _force;
    [SerializeField] private float _jump;
    void Start()
    {
        
    }  
    

    private void OnTriggerEnter(Collider other)
    {
        rb.AddForce(Vector3.up * _jump);
    }
}

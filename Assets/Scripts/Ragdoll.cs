using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour
{

    [SerializeField] private Animator _animator;
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody[] _allrigitbodies;
    


    private void Awake()
    {
        for(int i = 0; i < _allrigitbodies.Length; i++)
        {
            _allrigitbodies[i].isKinematic = true;
        }
    }
       
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * _speed * Time.deltaTime;
        }

        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DeadUnit();
        }
    }

    public void DeadUnit()
    {
        _animator.enabled = false;

        for (int i = 0; i < _allrigitbodies.Length; i++)
        {
            _allrigitbodies[i].isKinematic = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet04 : MonoBehaviour
{
    [SerializeField] float m_Speed;
    
    void Start()
    {

    }

    public  void Initialized(Transform Target)
    {
        transform.LookAt(Target);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * m_Speed * Time.deltaTime;
    }
}

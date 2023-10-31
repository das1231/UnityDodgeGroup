using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player02 : MonoBehaviour
{
    [SerializeField] float m_Speed = 1f;
    void Start()
    {
        
    }

    public void Initialize()
    {

    }

    void Update()
    {
        Move();
    }
    public void Move()
    {
        float xDelta = Input.GetAxisRaw("Horizontal");
        float zDelta = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(xDelta, 0, zDelta) * m_Speed * Time.deltaTime;
        transform.position += move;
    }
}

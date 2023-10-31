using UnityEngine;

public class Player : MonoBehaviour
{
    const float DEFAULT_SPEED = 10;
    public float m_moveSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        //float x = Input.GetAxisRaw("Horizontal");
        //float z = Input.GetAxisRaw("Vertical");
        //Vector3 move = new Vector3(x, 0, z) * m_moveSpeed * Time.deltaTime;
        //transform.position += move;

        float xDelta = Input.GetAxis("Horizontal");
        float zDelta = Input.GetAxis("Vertical");

        float x = xDelta * m_moveSpeed * Time.deltaTime * DEFAULT_SPEED;
        float z = zDelta * m_moveSpeed * Time.deltaTime * DEFAULT_SPEED;
        transform.Translate(x, 0, z, Space.World);
    }
}
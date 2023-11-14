using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    Rigidbody rigid;
    
    void Awake()
    {   
        rigid = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(x * speed * Time.deltaTime, 0, z * speed * Time.deltaTime),ForceMode.Impulse);
    }
}

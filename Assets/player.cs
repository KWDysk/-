using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    //移動速度
	public float speed = 3f;
    float moveX = 0f;
    float moveZ = 0f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * speed;
        moveZ = Input.GetAxis("Vertical") * speed;
        Vector3 direction = new Vector3(moveX, 0, moveZ);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ブスリ♂");
        SceneManager.LoadScene("cgame");
        
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(moveX, 0, moveZ);
    }
}



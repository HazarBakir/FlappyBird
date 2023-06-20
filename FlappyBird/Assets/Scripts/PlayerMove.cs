using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int pointCounter;
    Rigidbody2D rBody;
    public float jumpVelocity;
    public bool birdAlive;
    public TMP_Text point_counter;


    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        birdAlive = true;
        Jump();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdAlive && collision.gameObject.CompareTag("Collision"))
        {
            birdAlive = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (birdAlive && collision.tag == "PointLine")
        {
            pointCounter +=1;
            point_counter.SetText(pointCounter.ToString());
        }
    }
    void Jump()
    {
        rBody.velocity = Vector2.up * jumpVelocity;
    }

}

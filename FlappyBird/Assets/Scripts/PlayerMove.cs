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
    public CircleCollider2D circleCollider;
    public MonoBehaviour myCodeComponent;

    [SerializeField] private AudioSource jumpSoundEffect;
    [SerializeField] private AudioSource deathSoundEffect;

    void Start()
    {
        pointCounter = 0;
        rBody = GetComponent<Rigidbody2D>();
        birdAlive = true;
        Jump();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)&& Time.timeScale == 1)
        {
            Jump();
            jumpSoundEffect.Play();
        }
        if (pointCounter == 0 && !birdAlive)
        {
            PlayerPrefs.SetInt("Score", 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdAlive && collision.gameObject.CompareTag("Collision"))
        {
            birdAlive = false;
            circleCollider.enabled = false;
            deathSoundEffect.Play();
            Jump();
            myCodeComponent.enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (birdAlive && collision.tag == "PointLine")
        {
            pointCounter +=1;
            if (pointCounter > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", pointCounter);
            }
            PlayerPrefs.SetInt("Score", pointCounter);
            point_counter.SetText(pointCounter.ToString());
        }
    }
    void Jump()
    {
        rBody.velocity = Vector2.up * jumpVelocity;
        //jumpSoundEffect.Play();
        // made this comment because i use this function another place without sfx sound...

    }

}

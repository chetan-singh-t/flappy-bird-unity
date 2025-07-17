using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rb2;
    public float flapStrength;
    public Logic_Script logic;
    public bool birdIsAlive = true;
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_Script>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && birdIsAlive)
        {
            rb2.linearVelocity = Vector2.up * flapStrength;
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
        Time.timeScale = 0;
    }
}

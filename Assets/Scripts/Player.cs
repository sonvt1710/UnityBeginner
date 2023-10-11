using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public float velocity = 1.2f;
    public bool isDead = false;
    private Rigidbody2D rigidbody;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        gameManager.GameOver();
    }
}
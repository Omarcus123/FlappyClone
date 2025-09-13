using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class BirdScirpt : MonoBehaviour
{
    public Rigidbody2D myRigidbody; // Scripts can only talk to Game Objects's top bit and Transform, this reference allows use to give the 2D Object commands
    // *Side Note* The Collider is basically the hit box of the object
    public float flapStrength; // The float flapStrenth variable allows you to change the flapstrength without having to comeback to the code editor
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public LogicScript logic;
    public bool birdIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true) // If the user presses the spacebar run this if statement
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength; // Sends the bird upwards.
        }

        if (transform.position.x < -26 || transform.position.y < -16) // If the bird goes off the screen, the game is over
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}

using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed = -5;
    public float deadZone = -45;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; // Moves the pipe to the left and the set moveSpeed. Time.deltaTime makes things consistent across all computers

        if (transform.position.x < deadZone) // If the position of the gameobject on the x-axis is less than the deadzone, run this statement
        {
            Debug.Log("Pipe Deleted"); // prints a message in the debug log 
            Destroy(gameObject); // Destory the game object 
        }
    }
}

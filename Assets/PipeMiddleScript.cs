using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public BirdScirpt bird;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); // Use this if you want to reference another script
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScirpt>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && bird.birdIsAlive == true)
        { 
            logic.addScore(1);
        }
    }
}

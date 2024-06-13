using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction;
    public float jumpPower = 5f;
    public float gravity = -9.8f;
    //get scoremanager
    public GameObject scoreManager;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * jumpPower;
        }
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pipe")
        {
            Debug.Log("BAD!");
            scoreManager.GetComponent<ScoreManager>().youDied();
        }
        else if(collision.gameObject.tag == "Score")
        {
            Debug.Log("Good!");
            scoreManager.GetComponent<ScoreManager>().updateScore(1);
        }
        else
        {
            Debug.Log("??");
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    string String = "Hello ";
    int flower = 3;
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public int speed = 1000;
    public string nextLevel = "Scene_2";
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("Hello World");
        string String2 = "World";
        Debug.Log(String + String2);
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector2(-1, rb.velocity.y);
        //Debug.Log(flower);
        flower++;
        
       if (Input.GetKeyDown(KeyCode.W))
        {
           rb.velocity = new Vector2(rb.velocity.x, 10);
        }
        /*if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector2(-1, rb.velocity.y);
            //transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = new Vector2(rb.velocity.x, -10);
            //transform.position += new Vector3(0, -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(1, rb.velocity.y);
            //transform.position += new Vector3(1, 0, 0);
        }*/
        float xinput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xinput * speed, rb.velocity.y);


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hit");
        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    Debug.Log("Player Has Died");
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;

                }
        }
    }
}

                  
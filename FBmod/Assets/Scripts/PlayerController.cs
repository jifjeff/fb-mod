using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Vector2 jumpForce = new Vector2(0, 200);
    public Text myText;
    public Sprite sadFace;
    public Sprite happyFace;
    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        //spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space)){
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(jumpForce);
        }

        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height - 30 || screenPosition.y < 25)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sadFace;
            if (screenPosition.y > Screen.height || screenPosition.y < 0)
            {
                GameOver();
            }
            
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = happyFace;
        }

    }

    void FixedUpdate()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.name == "greenbook" || other.gameObject.name == "redbook")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sadFace;
            GameOver();         
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "score")
        {
            GameManager.score++;
        }
    }

    void GameOver()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = sadFace;
        myText.text = $"Number of Schoolwork evaded: {GameManager.score.ToString()}";
        Invoke("PlayAgain", 3f);
        
    }

    void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }

    private void OnGUI()
    {
        GUI.color = Color.black;
        GUI.Label(new Rect(10,10,100,20),$"Score: {GameManager.score.ToString()}");
    }
}

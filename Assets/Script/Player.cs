using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 pos;
    public float move;
    public float upBound;
    public float downBound;
    public int health = 3;
    public GameObject effect;
    public GameObject lost;
    public GameObject delScore;
    private Animator anim;
    public Text life;
    public GameObject thud;
    // Start is called before the first frame update
    void Start()
    {
        anim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        life.text = health.ToString();
        if(health == 0)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Destroy(gameObject);
            Destroy(delScore);
            lost.SetActive(true);
        }
        transform.position = Vector2.MoveTowards(transform.position, pos, 100*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > downBound)
        {
            anim.SetTrigger("shake");
            Instantiate(thud, transform.position, Quaternion.identity);
            pos = new Vector2(transform.position.x, transform.position.y - move);
            Instantiate(effect, transform.position, Quaternion.identity);
            Instantiate(thud, transform.position, Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < upBound)
        {
            anim.SetTrigger("shake");
            Instantiate(thud, transform.position, Quaternion.identity);
            pos = new Vector2(transform.position.x, transform.position.y + move);
            Instantiate(effect, transform.position, Quaternion.identity);
            Instantiate(thud, transform.position, Quaternion.identity);
        }
        }
}

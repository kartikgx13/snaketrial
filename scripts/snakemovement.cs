using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class snakemovement : MonoBehaviour
{
    private Vector2 direction=Vector2.right;

    private List<Transform> segments = new List<Transform>();

    public Transform segmentsPrefab;

    public Image imagequestion;

    public List<Sprite> spriteList;

    private static int currentQuestionIndex;

    private static int count;

    private static int temp;

    public Text scoreText;

    public static string sceneName;

    //bool backimg = pauseMenu.check;


    private void Start()
    {
        currentQuestionIndex = 0;
        //BackQuestionImage();
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        
        PlayerPrefs.GetInt("CurrentIndex");
        PlayerPrefs.GetInt("CurrentAnswer");
      
        ResetState();
        
        
    }

    

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            moveUp();
            //Debug.Log(temp);
            /* if (count == temp)
             {
                 Debug.Log("true");
             }*/
            
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            moveLeft();
            //Debug.Log(temp);
            /*if (count == temp)
            {
                Debug.Log("true");
            }*/
            
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            moveDown();
            //Debug.Log(temp);
            /*if (count == temp)
            {
                Debug.Log("true");
            }*/
            
        }
        else  if (Input.GetKeyDown(KeyCode.D))
        {
            moveRight();
            //Debug.Log(temp);
            /* if (count == temp)
             {
                 Debug.Log("true");
             }*/
            
        }

        RotateSprite();

        PlayerPrefs.SetInt("CurrentIndex", currentQuestionIndex);
        PlayerPrefs.SetInt("CurrentAnswer", temp);

        Count();

        ScoreDisplay();
            
        
        


    }

    public void moveUp()
    {
        direction = Vector2.up;
    }

    public void moveDown()
    {
        direction = Vector2.down;
    }

    public void moveLeft()
    {
        direction = Vector2.left;
       
    }

    public void moveRight()
    {
        direction = Vector2.right;
        
    }


    private void FixedUpdate()
    {
        
        for (int i = segments.Count - 1; i > 0; i--)
        {
            segments[i].position = segments[i - 1].position;
        }


        this.transform.position = new Vector3(Mathf.Round(this.transform.position.x) + direction.x, Mathf.Round(this.transform.position.y) + direction.y,0.0f);

        //Debug.Log(count);

        

    }

    public void ResetState()
    {
        for (int i = 1; i < segments.Count; i++)
        {
            Destroy(segments[i].gameObject);
        }

        segments.Clear();
        segments.Add(this.transform);

        this.transform.position = Vector3.zero;


    }

    private void Grow()
    {
        Transform bodySegment = Instantiate(this.segmentsPrefab);
        bodySegment.position = segments[segments.Count - 1].position;
        segments.Add(bodySegment);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Food")
        {
            Grow();
        }

        else if (other.tag == "Obstacle")
        {
            ResetState();
            
        }
        else if(count==temp && other.tag=="goal")
        {
            //scene correct;
            SceneManager.LoadScene("correct scene");
           
           
        }

        else if (count > temp && other.tag == "goal")
        {
            //scene wrong;
            SceneManager.LoadScene("end scene");
           

        }
        else if (count < temp && other.tag == "goal")
        {
            //scene wrong;
            SceneManager.LoadScene("end scene");
           

        }

        

    }

    public void Next()
    {

        currentQuestionIndex += 1;
        for (int i = 0; i < spriteList.Count; i++)
        {
            imagequestion.sprite = spriteList[currentQuestionIndex];

        }
        
        Debug.Log(currentQuestionIndex);
       
    }

    public void Previous()
    {

        currentQuestionIndex -= 1;
        for (int i = 0; i < spriteList.Count; i++)
        {
            imagequestion.sprite = spriteList[currentQuestionIndex];

        }
       
        Debug.Log(currentQuestionIndex);
        
    }


    
     public void CompareAnswer()
    {
        

       // Debug.Log("Compare answer wala"+PlayerPrefs.GetInt("CurrentIndex"));

        //Debug.Log("Compare answer wala" + imageQuestion[PlayerPrefs.GetInt("CurrentIndex")].gameObject.name);

        temp = int.Parse(spriteList[currentQuestionIndex].name);

        Debug.Log("before loading scene temp = " + " " + temp);

       /*if(count==temp)
        {
            Debug.Log("true");
        }*/

        
        

    } 

      public void Count()
    {
        
        count = segments.Count;
    }
     public void PlayGame()
    {
        SceneManager.LoadScene("maingame");
        Debug.Log(currentQuestionIndex);
        CompareAnswer();
    } 

   public void restartGame()
    {
        ResetState();
    }

    public void ScoreDisplay()
    {
        if(sceneName=="maingame")
        {
            scoreText.text = (count).ToString("0");
        }
        
    }

    public void RotateSprite()
    {
        transform.eulerAngles = new Vector3(0, 0, GetAngleFromVector(direction)-90);
    }

    public float GetAngleFromVector(Vector2 dir)
    {
        float n = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        if(n<0)
        {
            n += 360;
        }

        return n;
    }

   /* public void BackQuestionImage()
    {
        if(backimg)
        {
            imagequestion.sprite = spriteList[currentQuestionIndex];
        }
    }*/
    
}


using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonPress : MonoBehaviour
{
    public GameObject clickMe;
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        // gameOver.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Click()
    {
        transform.position = new Vector2(Random.Range(0f, Screen.width), Random.Range(0f, Screen.height));
        // Vector2 randomPosition = new Vector2(Random.Range(0f, Screen.width), Random.Range(0f, Screen.height));
    }
    public void Outside()
    {
        clickMe.SetActive(false);
        gameOver.SetActive(true);


    }
    public void ReloadScene()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;


        SceneManager.LoadScene(currentSceneIndex);
    }

}

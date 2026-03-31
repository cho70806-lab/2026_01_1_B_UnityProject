using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxLives = 3;
    public int curentLives;

    public float invincibleTime = 1.0f;
    public bool isinvincble = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        curentLives = maxLives;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("missile"))
        {
            curentLives--;
            Destroy(other.gameObject);

            if(curentLives <- 0)
            {
                GameOver();
            }
        }
    }

    void GameOver()
    {
        gameObject.SetActive(false);
        Invoke("RestartGame", 3.0f);
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}

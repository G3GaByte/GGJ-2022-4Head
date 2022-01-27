using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCollider : MonoBehaviour
{
    [SerializeField] string playerName = "Player";
    [SerializeField] float restartDelay = 1.5f;
    FadeBlack fadeBlack;

    private void Start()
    {
        fadeBlack = FindObjectOfType<FadeBlack>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == playerName)
        {
            //TODO: Get player state, play vfx depending on state
            Debug.Log("Death Collider Triggered. Restaring Level in: " + restartDelay + " seconds." );

            if(fadeBlack)
                fadeBlack.Fade(0, 1, restartDelay);

            Invoke("RestartLevel", restartDelay);
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

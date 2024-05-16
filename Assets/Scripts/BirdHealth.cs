using UnityEngine;

public class BirdHealth : MonoBehaviour
{
    public GameManager gameManager;
    public AudioSource src;
    public AudioClip sfx2;

    private void Start()
    {
        var gameController = GameObject.FindGameObjectWithTag("GameController");
        gameManager = gameController.GetComponent<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        src.clip = sfx2;
        src.Play();
        gameManager.GameOver();
    }
}

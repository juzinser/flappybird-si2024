using UnityEngine;

public class Points : MonoBehaviour
{
    public GameManager gameManager;
    public AudioSource src;
    public AudioClip sfx3;

    private void Start()
    {
        var gameController = GameObject.FindGameObjectWithTag("GameController");
        gameManager = gameController.GetComponent<GameManager>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameManager.Score++;
        src.clip = sfx3;
        src.Play();
    }
}

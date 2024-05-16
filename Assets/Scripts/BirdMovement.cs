using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public float speed = 1f;
    private string x = "Jump";
    private string y = "BlueJump";
    public AudioSource src;
    public AudioClip sfx1;

    private Rigidbody2D _rigidbody;
    private Animator _animator;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            _rigidbody.velocity = Vector2.up * speed;
            _animator.SetTrigger(x);
            src.clip = sfx1;
            src.Play();

        }
        /*if (!_animator.SetTrigger(x))
        {
            _animator.SetTrigger(x);
        }
        if (!_animator.SetTrigger(y))
        {
            _animator.SetTrigger(y);
        }*/
    }






}

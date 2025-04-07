using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private AudioManager _audioManager;
    private Rigidbody2D _rigidbody2D;
    public float JumpForce = 5f;

    private float _maxRotation = 30f;
    private float _minRotation = -60f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion targetRotation = Quaternion.Euler(0f, 0f , _minRotation);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.velocity = Vector2.up * JumpForce;
            transform.rotation = Quaternion.Euler(0, 0, _maxRotation);
            _audioManager.FlyClip();
        }
        
        if (GamePause.IsGamePaused)
        {
            return;
        }
        
    
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime);
        
        if(transform.position.y >= 4f)
        {
            var vector3 = transform.position;
            vector3.y = 4f;
            transform.position = vector3;
        }
    }
    
}
using UnityEngine;

public class Pug : Animal
{
    [SerializeField] float _speed;

    public float Speed
    {
        get { return _speed; }
        private set
        {
            if (_speed >= 0 && _speed <= 10)
            { _speed = value; }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement(_speed);
        Dead();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Barrier")
        {
            Jump();
        }
    }
}

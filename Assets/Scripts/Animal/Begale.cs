using UnityEngine;

public class Begale : Animal
{
    // POLYMORPHISM : Begale dog had diff. speed which is set in Animal Movement(float s) Method
    [SerializeField] private float _speed;

    // ENCAPSULATION : Dogs Speed must not increase more than 10 and not 0
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

    // ABSTRACTION : in Update Use Animal class Movement Method
    void Update()
    {
        Movement(Speed);
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

using UnityEngine;

public class BorderCollie : Animal
{
    [SerializeField] float _speed;

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

using System.Collections;
using UnityEngine;

public class Animal : MonoBehaviour
{
    protected Rigidbody _rb;
    protected Animator _animator;

    private int _jumpForce = 400;
    private bool _isVehicleInFront = false;

    // INHERITANCE : Jump(), Movement() and Dead() Parent class of Animal which will used by Child classes
    protected void Jump()
    {
        _rb.AddForce(Vector3.up * _jumpForce);
        _animator.SetBool("Jumping", true);
    }

    protected void Movement(float s)
    {
        if (!_isVehicleInFront)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * s);
        }
    }

    protected void Dead()
    {
        if (transform.position.x > 59.5f)
        { Destroy(this.gameObject); }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _animator.SetBool("Jumping", false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Vehicle")
        {  
            _isVehicleInFront = true;
            _animator.SetBool("Barking", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Vehicle")
        { 
            _isVehicleInFront = false;
            _animator.SetBool("Barking", false);
        }
    }
}
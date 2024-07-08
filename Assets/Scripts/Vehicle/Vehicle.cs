using UnityEngine;

public class Vehicle : MonoBehaviour
{
    protected void Move(float s)
    {
        transform.Translate(Vector3.forward * s * Time.deltaTime);
    }

    protected void VehicleDestroy()
    {
        if (transform.position.z < -10.5f || transform.position.z > 84.0f)
        { Destroy(this.gameObject); } 
    }
}

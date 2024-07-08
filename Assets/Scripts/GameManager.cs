using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int a;
    // Start is called before the first frame update
    void Start()
    {
        a = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (a >= 4)
            { a = 0; }
            else { a++; }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (a <= 0)
            { a = 4; }
            else { a--; }
        }

        switch (a) 
        {
            case 0:
                transform.position = new Vector3(-0.4f, 28.4f, -23.8f);
                transform.localEulerAngles = new Vector3(40, 0, 0);
                break;

            case 1:
                transform.position = new Vector3(-0.4f, 28.4f, 95.3f);
                transform.localEulerAngles = new Vector3(40, 180, 0);
                break;

            case 2:
                transform.position = new Vector3(-69.4f, 28.4f, 36.6f);
                transform.localEulerAngles = new Vector3(40, 90, 0);
                break;

            case 3:
                transform.position = new Vector3(69.6f, 28.4f, 36.6f);
                transform.localEulerAngles = new Vector3(40, 270, 0);
                break;

            case 4:
                transform.position = new Vector3(0.0f, 48.5f, 35.7f);
                transform.localEulerAngles = new Vector3(90, 0, 0);
                break;
        }
    }
}

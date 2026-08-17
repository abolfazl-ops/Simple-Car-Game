using UnityEngine;

public class Player : MonoBehaviour
{
    public float forwardSpeed = 10f;
    public float sideSpeed = 6.5f;
    void Start()
    {
        Debug.Log("Game Has Been Started");
    }

    void Update()
    {
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
        
        //Side Movement
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * sideSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * sideSpeed * Time.deltaTime);
        }
    }
}

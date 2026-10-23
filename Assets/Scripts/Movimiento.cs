using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float velocidad = 5f; // Velocidad de movimiento del objeto
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.UpArrow))
        {
          transform.Translate(Vector3.up * velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
          transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
          transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }


          if (Input.GetKey(KeyCode.W))
        {
          transform.Translate(Vector3.up * velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
          transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
          transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
    }
}

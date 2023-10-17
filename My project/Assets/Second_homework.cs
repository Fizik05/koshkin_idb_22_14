using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Second_homework : MonoBehaviour
{
    public GameObject Cylinder;
    public bool status_of_cube;
    public float Speed = 10f;
    private int health = 5;
    public Text health_text;

    void Start()
    {
        Debug.Log("Started");
    }

    void FixedUpdate()
    {
        if (health < 1) {
            this.gameObject.SetActive(false);
            health_text.text = "Game over";
        }
        else {
            health_text.text = "Your health is " + health.ToString();
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 5 * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 5 * Speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Cylinder) {
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
            health--;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("EXIT");
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }

    private void OnCollisionStay(Collision collision)
    {
        // Debug.Log("STAY");
    }

    public void onClick()
    {
        health = 5;
        this.gameObject.SetActive(true);
    }
}
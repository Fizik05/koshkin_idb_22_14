using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class First_homework : MonoBehaviour
{
    public GameObject Cylinder;
    public bool status_of_cube;
    public Text text;

    public void onClick()
    {
        status_of_cube = this.gameObject.activeSelf;

        if (status_of_cube)
        {
            this.gameObject.SetActive(false);
            text.text = "Cube deactivated";
        }
        else
        {
            this.gameObject.SetActive(true);
            text.text = "Cube activated";
        }
    }
}
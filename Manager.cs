using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public GameObject Red, Yellow, Green, Blue;
    public Transform cameraPos;
    public Transform redPos, yellowPos, greenPos, bluePos;

    void Update()
    {
        if (Input.GetButtonDown("Red"))
        {
            cameraPos.position = Vector3.Lerp(cameraPos.position, redPos.position, 10);
            Yellow.GetComponent<YellowController>().yellowInPlay = false;
            Green.GetComponent<GreenController>().greenInPlay = false;
            Blue.GetComponent<BlueController>().blueInPlay = false;
            Red.GetComponent<RedController>().redInPlay = true;
        }
        if (Input.GetButtonDown("Yellow"))
        {
            cameraPos.position = Vector3.Lerp(cameraPos.position, yellowPos.position, 10);
            Yellow.GetComponent<YellowController>().yellowInPlay = true;
            Green.GetComponent<GreenController>().greenInPlay = false;
            Blue.GetComponent<BlueController>().blueInPlay = false;
            Red.GetComponent<RedController>().redInPlay = false;
        }
        if (Input.GetButtonDown("Green"))
        {
            cameraPos.position = Vector3.Lerp(cameraPos.position, greenPos.position, 10);
            Yellow.GetComponent<YellowController>().yellowInPlay = false;
            Green.GetComponent<GreenController>().greenInPlay = true;
            Blue.GetComponent<BlueController>().blueInPlay = false;
            Red.GetComponent<RedController>().redInPlay = false;
        }
        if (Input.GetButtonDown("Blue"))
        {
            cameraPos.position = Vector3.Lerp(cameraPos.position, bluePos.position, 10);
            Yellow.GetComponent<YellowController>().yellowInPlay = false;
            Green.GetComponent<GreenController>().greenInPlay = false;
            Blue.GetComponent<BlueController>().blueInPlay = true;
            Red.GetComponent<RedController>().redInPlay = false;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }
        



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Red") && collision.CompareTag("Yellow"))
        {
            SceneManager.LoadScene(2);
        }
    }
}

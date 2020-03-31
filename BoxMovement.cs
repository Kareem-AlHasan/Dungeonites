using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    public Rigidbody2D redBoxRb, yellowBoxRb, greenBoxRb, blueBoxRb;
    public Transform redBox, yellowBox, greenBox, blueBox;
    private Vector2 initialRedBoxPos, initialYellowBoxPos, initialGreenBoxPos, initialBlueBoxPos,lastPosRed, lastPosYellow, lastPosGreen, lastPosBlue;
    private void Start()
    {
        lastPosRed = redBox.position;
        lastPosYellow = yellowBox.position;
        lastPosGreen = greenBox.position;
        lastPosBlue = blueBox.position;
    }
    private void Update()
    {
        initialRedBoxPos = redBox.position;
        initialYellowBoxPos = yellowBox.position;
        initialGreenBoxPos = greenBox.position;
        initialBlueBoxPos = blueBox.position;

        if (initialRedBoxPos != lastPosRed)
        {
            yellowBox.position = new Vector2(redBox.position.x - 46, redBox.position.y);
            greenBox.position = new Vector2(redBox.position.x - 46, redBox.position.y - 28);
            blueBox.position = new Vector2(redBox.position.x, redBox.position.y - 28);
        }
        if (initialYellowBoxPos != lastPosYellow)
        {
            redBox.position = new Vector2(yellowBox.position.x + 46, yellowBox.position.y);
            greenBox.position = new Vector2(yellowBox.position.x, yellowBox.position.y - 28);
            blueBox.position = new Vector2(yellowBox.position.x + 46, yellowBox.position.y - 28);
        }
        if (initialGreenBoxPos != lastPosGreen)
        {
            redBox.position = new Vector2(greenBox.position.x + 46, greenBox.position.y + 28);
            yellowBox.position = new Vector2(greenBox.position.x, greenBox.position.y + 28);
            blueBox.position = new Vector2(greenBox.position.x + 46, greenBox.position.y);
        }
         if (initialBlueBoxPos != lastPosBlue)
        {
            redBox.position = new Vector2(blueBox.position.x, blueBox.position.y + 28);
            yellowBox.position = new Vector2(blueBox.position.x - 46, blueBox.position.y + 28);
            greenBox.position = new Vector2(blueBox.position.x - 46, blueBox.position.y);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            redBoxRb.velocity = Vector3.zero;
            yellowBoxRb.velocity = Vector3.zero;
            greenBoxRb.velocity = Vector3.zero;
            blueBoxRb.velocity = Vector3.zero;
        }
        lastPosRed = initialRedBoxPos;
        lastPosYellow = initialYellowBoxPos;
        lastPosGreen = initialGreenBoxPos;
        lastPosBlue = initialBlueBoxPos;


    }
}

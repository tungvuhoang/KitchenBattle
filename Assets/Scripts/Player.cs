using UnityEngine;

public class Player : MonoBehaviour
{
    private float moveSpeed = 10f; 
    void Update()
    {
        Vector2 inputVector = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y -= 1;
        }
        if (Input.GetKey(KeyCode.D)) 
        { 
            inputVector.x += 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x -= 1;
        }

        Vector3 moveDir = new Vector3(inputVector.x, 0, inputVector.y);
        moveDir = moveDir.normalized;

        transform.position += moveDir * moveSpeed * Time.deltaTime;
    }
}

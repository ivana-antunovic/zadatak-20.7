using UnityEngine;

public class Player : MonoBehaviour
{
    private float playerSpeed = 5f;
    public bool hasKey = false;

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))                    
        {                                             
            Move(Vector2.right);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Move(Vector2.left);

        }

    }

    private void Move(Vector2 direction)
    {
        transform.position += (Vector3)(direction * playerSpeed * Time.deltaTime);
    }

    // stavila sam skriptu na playera. ponavljam stalno istu skriptu jer if it aint broke...
}

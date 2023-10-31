using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]float moveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
      InstruccionsGame();
    }

    // Update is called once per frame
    void Update()
    {
      
      movement();
        
    }

    void movement()
    {
      float movementX = movementX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
      float movementY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
      transform.Translate(movementX,0,movementY);
    }

    void InstruccionsGame()
    {
      Debug.Log("Welcome to the simple game");
      Debug.Log("Move your player with WASD or arrow Keys");
      Debug.Log("Don't HIT the walls");

    }
}
 

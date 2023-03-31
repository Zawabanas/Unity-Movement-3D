using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController Player;
    private float horizontalMove;
    private float verticalMove;
    public float PlayerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        Player.Move(new Vector3(horizontalMove, 0, verticalMove) * PlayerSpeed * Time.deltaTime);
    }
}

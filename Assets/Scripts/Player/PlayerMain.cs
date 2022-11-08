using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    [HideInInspector] public PlayerInputs input;
    [HideInInspector] public PlayerMovement movement;
    [HideInInspector] public PlayerCollision collision;
    [HideInInspector] public PlayerState state;

    private void Awake()
    {
        input = GetComponent<PlayerInputs>();
        movement = GetComponent<PlayerMovement>();
        collision = GetComponent<PlayerCollision>();
        state = GetComponent<PlayerState>();
    }
}
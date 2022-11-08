using UnityEngine;

namespace Project.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [Header("References")]
        private PlayerMain player;
        private Rigidbody2D rb;

        [Header("Variables")]
        public float accelerationSpeed;
        public float maxSpeed;

        private void Awake()
        {
            player = GetComponent<PlayerMain>();
        }

        private void FixedUpdate()
        {
            Vector2 moveVector = player.input.MoveVector;
            if(moveVector == Vector2.zero && rb.velocity != moveVector)
                Deccelerate();
            else if(moveVector != Vector2.zero)
                Accelerate();
        }

        private void Deccelerate()
        {
            rb.AddForce(rb.velocity - player.input.MoveVector);
        }

        private void Accelerate()
        {

        }
    }
}
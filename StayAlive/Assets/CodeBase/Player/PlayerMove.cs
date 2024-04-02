using UnityEngine;

namespace CodeBase.Player
{
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private float _speed = 4f;

        private float movementVectorX;
        private float movementVectorZ;
        public Infrastructure.Service.InputService _inputService;
        private Camera _camera;
        private Vector3 move;


        private void Update()
        {
            movementVectorX = 0;
            movementVectorZ = 0;
            if (Input.GetAxis("Horizontal") != 0)
            {
                movementVectorX = Input.GetAxis("Horizontal");
            }

            if (Input.GetAxis("Vertical") != 0)
            {
                movementVectorZ = Input.GetAxis("Vertical");
            }

            move = new Vector3(movementVectorX, 0, movementVectorZ);
            transform.forward = move;
        }

        private void FixedUpdate()
        {
            transform.position += move * _speed * Time.fixedDeltaTime;
        }
    }
}
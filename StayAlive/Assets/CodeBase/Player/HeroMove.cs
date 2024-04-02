using CodeBase.Infrastructure.Service;
using UnityEngine;

namespace CodeBase.Player
{
    public class HeroMove : MonoBehaviour
    {
        [SerializeField] private CharacterController _charecterController;
        [SerializeField] private float _speed;
        private IInputService _inputService;
        private Camera _camera;

        private void Awake()
        {
            _inputService = Game.InputService;
        }

        private void Start()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            Vector3 movementVector = Vector3.zero;
            if (_inputService.Axis.sqrMagnitude > 0.001f)
            {
                movementVector = _camera.transform.TransformDirection(_inputService.Axis);
                movementVector.y = 0;
                movementVector.Normalize();

                transform.forward = movementVector;
            }
            
            _charecterController.Move(_speed * movementVector * Time.deltaTime);
        }
    }
}
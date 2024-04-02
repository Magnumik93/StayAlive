using UnityEngine;
using UnityEngine;

namespace CodeBase.Infrastructure.Service
{
    public abstract class InputService : IInputService
    {
        protected const string Horizontal = "Horizontal";
        protected const string Vertical = "Vertical";

        public abstract Vector2 Axis { get; }
    }

    public class StandaloneInputService : InputService
    {
        public override Vector2 Axis
        {
            get
            {
                Vector2 axis = UnityInput();
                return axis;
            }
        }
        
        private Vector2 UnityInput() => 
            new Vector2(Input.GetAxis(Horizontal), Input.GetAxis(Vertical));
    }
}
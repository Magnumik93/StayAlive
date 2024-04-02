using CodeBase.Infrastructure.Service;
using UnityEngine;

namespace CodeBase
{
    public class Game : MonoBehaviour
    {
        public static IInputService InputService;

        public Game()
        {
            InputService = new StandaloneInputService();
        }
    }
}
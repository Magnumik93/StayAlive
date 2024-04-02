using UnityEngine;

namespace CodeBase
{
   public class GameBootstraper : MonoBehaviour
   {
      private Game _game;
      private void Awake()
      {
         _game = new Game();
         
         DontDestroyOnLoad(this);
      }
   }
}
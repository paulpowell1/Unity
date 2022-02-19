using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endtrigger : MonoBehaviour
{
   public PlayerMovement Player;
   void OnTriggerEnter ()
    {
        Player.Complete();
    }
}

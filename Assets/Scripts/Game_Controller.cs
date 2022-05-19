using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class Game_Controller : MonoBehaviour
{
   
    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
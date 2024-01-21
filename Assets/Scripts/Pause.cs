using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public Space space;
    public Player player;

    public void Stop()
    {
        Time.timeScale = 0;
    }
}

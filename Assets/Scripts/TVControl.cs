using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TVControl : MonoBehaviour
{
    public VideoPlayer player;
    // Start is called before the first frame update
    void Start()
    {
        TurnOffTV();
    }

    public void TurnOnTV()
    {
        if(player.isPlaying == false)
        {
            player.Play();
        }
        else
        {
            TurnOffTV();
        }
        
    }

    public void TurnOffTV()
    {
        player.Stop();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NurseControl : MonoBehaviour
{
    public Light nurseLight;
    public AudioSource audioSource;
    void Start()
    {
        TurnOffLight();
    }

    public void TurnOnLight()
    {
        if (nurseLight.intensity == 0)
        {
            nurseLight.intensity = 1.95f;
            audioSource.Play();
        }
        else if (nurseLight.intensity == 1.95f)
        {
            TurnOffLight();
        }

    }

    public void TurnOffLight()
    {
        nurseLight.intensity = 0f;
        audioSource.Stop();
    }
}

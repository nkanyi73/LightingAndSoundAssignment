using UnityEngine;

public class EF : MonoBehaviour
{
    public Material targetMaterial; // Drag and drop the material you want to modify in the inspector
    public float minEmission = 0.0f; // Minimum emission value
    public float maxEmission = 1.0f; // Maximum emission value
    public float fluctuationSpeed = 1.0f; // Speed of the fluctuation

    void Update()
    {
        // Calculate the emission value based on time
        float emissionValue = Mathf.PingPong(Time.time * fluctuationSpeed, maxEmission - minEmission) + minEmission;

        // Make sure the material has emission enabled
        targetMaterial.EnableKeyword("_EMISSION");

        // Get the current color of the material
        Color baseColor = targetMaterial.GetColor("_EmissionColor");

        // Set the emission color with the modified intensity
        Color emissionColor = new Color(emissionValue, baseColor.g, baseColor.b);

        // Set the emission color to the material
        targetMaterial.SetColor("_EmissionColor", emissionColor);
    }
}

using UnityEngine;

public class Sphere : MonoBehaviour
{
    // Властивості для елемента гри Сфера
    public float Radius { get; set; }
    public Color Color { get; set; }

    // Конструктор класу
    public Sphere(float radius, Color color)
    {
        Radius = radius;
        Color = color;
    }

}

using UnityEngine;
using System.Collections;

public class DooR : MonoBehaviour
{
    [Header("旋轉角度"), Range(0, 180)]
    public float Angle = 90;
    [Header("旋轉速度"), Range(0, 100)]
    public float Speed = 1.5F;

    public void Open()
    {

    }
}

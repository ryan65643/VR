using UnityEngine;
using System.Collections;
//要求元件(類型(元件類型),再套用腳本時才會觸發
[RequireComponent(typeof(AudioSource))]
public class DooR : MonoBehaviour
{
    [Header("旋轉角度"), Range(0, 180)]
    public float Angle = 90;
    [Header("旋轉速度"), Range(0, 100)]
    public float Speed = 1.5F;
    [Header("音效")]
    public AudioClip sound;
    [Header("音量大小"), Range(0, 5)]
    public float V = 1;

    private AudioSource aud;
    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    public void Open()
    {
        StartCoroutine(open());
    }

    private IEnumerator open()
    {
        aud.PlayOneShot (sound, V);
        while (transform.rotation!= Quaternion.Euler(0,Angle,0))
        {
            transform.rotation = Quaternion.Euler(0, Angle, Speed * Time.deltaTime);
            yield return null;
        }
    }
}

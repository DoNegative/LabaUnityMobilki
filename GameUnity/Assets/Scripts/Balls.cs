using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balls : MonoBehaviour
{
    private int balls = 0;
    public Text Text;
    private void OnTriggerEnter2D(Collider2D other)
    {
        balls++;
        Text.text = "Количество шаров:" + balls;
        Destroy(other.gameObject);
    }
}

using System;
using UnityEngine;

public class Colision : MonoBehaviour
{
    
    [SerializeField] private float destroyDelay = 0.5f;
    private bool hasPackage;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entrando a Trigger");
        if (other.tag == "Paquete" && !hasPackage)
        {
            Debug.Log("Recogio paquete");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "Cliente" && hasPackage)
        {
            Debug.Log("Dejo paquete!");
            hasPackage = false;
            spriteRenderer.color = Color.cyan;
        }
    }
    
}

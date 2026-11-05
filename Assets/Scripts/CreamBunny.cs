using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreamBunny : MonoBehaviour
{
    public int vidas = 3;
    public float velocidad = 6f;          
    private Rigidbody2D rb;              

    public GameObject prefabFrutilla; 
    public Transform puntoDisparo;    
    public float velocidadFrutilla = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("Vidas restantes: " + vidas);
    }
    void Update()
       {
        float movimientoX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(movimientoX * velocidad, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
     {
            rb.velocity = new Vector2(rb.velocity.x, velocidad);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            TirarFrutilla();
        }
            }
    void TirarFrutilla()
    {
        if (prefabFrutilla != null && puntoDisparo != null)
        {
            GameObject frutilla = Instantiate(prefabFrutilla, puntoDisparo.position, Quaternion.identity);
            frutilla.GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadFrutilla, 0f);
        }
      }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        vidas = vidas - 1;
        Debug.Log("¡Ay! Vidas restantes: " + vidas);
        if (vidas <= 0)
        {
            Debug.Log("Game Over");
        }
        }
}
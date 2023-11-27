using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageController : MonoBehaviour
{
    private Rigidbody2D _compRigidbody2D;
    private SpriteRenderer _compSpriteRend;
    public int velocidadX;
    public int velocidadY;
    public int direccionX;
    public int direccionY;
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        _compSpriteRend = GetComponent<SpriteRenderer>();
        velocidadX = 10;
        velocidadY = 10;
        direccionX = 1;
        direccionY = 1;
    }
    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(velocidadX * direccionX , velocidadY * direccionY);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "HorizontalWall")
        {
            if (direccionX == 1)
            {
                direccionX = -1;
                _compSpriteRend.flipX = true;
            }
            else if (direccionX == -1)
            {
                direccionX = 1;
                _compSpriteRend.flipX = false;
            }
        }
        if (collision.gameObject.tag == "VerticalWall")
        {
            if (direccionY == 1)
            {
                direccionY = -1;
                _compSpriteRend.flipY = true;
            }
            else if (direccionY == -1)
            {
                direccionY = 1;
                _compSpriteRend.flipY = false;
            }
        }
    }
}

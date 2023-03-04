using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raquetas : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    [SerializeField] private bool isRaqueta1;
    private float yBound = 3.75f;


    // Update is called once per frame
    void Update()
    {
        float movement;

        if(isRaqueta1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }


        Vector2 raquetaPosition = transform.position;
        raquetaPosition.y = Mathf.Clamp(raquetaPosition.y + movement * speed * Time.deltaTime, -yBound, yBound);
        transform.position = raquetaPosition;
    }
}

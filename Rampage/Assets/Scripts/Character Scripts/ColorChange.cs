using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    //Enemies continuously changing color like a police siren
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private Color initialColor;
    [SerializeField] private Color Color2;
    [SerializeField] private bool loops = false;
    float startTime;
    
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //if we loop, change the color
        if(!loops)
        {
            float t = (Time.time - startTime) * speed * Time.deltaTime;
            GetComponent<Renderer>().material.color = Color.Lerp(initialColor, Color2, t);
        }
        //otherwise stay in Color2 state
        else
        {
            float t = (Mathf.Sin(Time.time - startTime) * speed);
            GetComponent<Renderer>().material.color = Color.Lerp(initialColor, Color2, t);
        }
        
    }
}

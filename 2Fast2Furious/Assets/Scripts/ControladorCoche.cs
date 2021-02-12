using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCoche : MonoBehaviour
{

    public GameObject cocheGO;

    public float anguloDeGiro;
    public float velocidad;



    // Start is called before the first frame update
    void Start()
    {

        cocheGO = GameObject.FindObjectOfType<Coche>().gameObject;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float giroEnZ = 0;
        transform.Translate(Vector2.right * Input.GetAxis("Horizontal") * velocidad * Time.deltaTime);

        giroEnZ = Input.GetAxis("Horizontal") * -anguloDeGiro;

        cocheGO.transform.rotation = Quaternion.Euler(0,0, giroEnZ);

    }
}

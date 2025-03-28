using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{

    public string nombre;
    public int edad;
    public float estatura;
    public bool esDonante;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("mi nombre es " + nombre + " tengo " + edad + " mido " + estatura + " metros y es " + esDonante + " que soy donante de organos");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

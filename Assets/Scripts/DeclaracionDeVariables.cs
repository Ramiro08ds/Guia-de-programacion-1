using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    int EscenasMalas = 8;
    string NombrePelicula = "Minecraft";
    float AlturaSteve = 1.90f;
    bool EsBuena = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(EscenasMalas);
        Debug.Log(NombrePelicula);
        Debug.Log(AlturaSteve);
        Debug.Log(EsBuena);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

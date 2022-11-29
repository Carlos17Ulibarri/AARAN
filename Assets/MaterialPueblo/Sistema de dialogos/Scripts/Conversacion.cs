using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityExtensions;


[CreateAssetMenu(fileName = "Conversacion", menuName = "Sistema de dialogos/Nueva conversacion", order = 0)]
public class Conversacion : ScriptableObject 
{
    [System.Serializable]
    public struct Linea
    {
        public Personaje personaje;

        public AudioClip sonido;

        [TextArea(3, 5)]
        public string dialogo;
    }
    
    public bool desbloqueada;
    public bool finalizado; 
    public bool reUsar;

    [ReorderableList]
    public Linea[] dialogos; 
    
    public Preguntas pregunta;
}


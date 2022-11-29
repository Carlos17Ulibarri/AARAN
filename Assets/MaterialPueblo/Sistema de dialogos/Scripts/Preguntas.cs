using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityExtensions;

[System.Serializable]

public struct Opciones
{
    [TextArea(2,4)]
    public string opcion;
    public Conversacion convResultante;
    public string escena;
}


[CreateAssetMenu(fileName = "Preguntas", menuName = "Sistema de dialogos/Preguntas", order = 0)]
public class Preguntas : ScriptableObject 
{
    [TextArea(3,5)]
    public string pregunta;
    
    [ReorderableList]
    public Opciones[] opciones;    

}
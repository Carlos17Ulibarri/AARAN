using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityExtensions;
using UnityEngine.UI;

public class DialogueSpeaker : MonoBehaviour
{
    [ReorderableList]
    public List<Conversacion> conversacionesDisponibles = new List<Conversacion>();

    [SerializeField]
    private int indexDeConversaciones = 0;

    public int dialLocalIn = 0;

    private int buttonPressedCounter = 0;
    public GameObject Boton;

    


    void Start()
    {
        indexDeConversaciones = 0;
        dialLocalIn = 0;
        Boton.SetActive(false);

        //solo debug
        foreach (var conv in conversacionesDisponibles)
        {
            conv.finalizado = false;
            var preg = conv.pregunta;

            if(preg != null)
            {
                foreach (var opcion in preg.opciones)
                {
                    opcion.convResultante.finalizado = false;
                }
            }
        }
        //solo debug
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            Boton.SetActive(true);
        }
        if(other.CompareTag("Player"))
        {
            DialogoManager.instance.CambiarEstadodeReUsable(conversacionesDisponibles[indexDeConversaciones], !conversacionesDisponibles[indexDeConversaciones].reUsar);
        }
    }

    public void Accion()
    {
        buttonPressedCounter++;
        if(buttonPressedCounter == 1)
        {
            Conversar();
        }
    }    

    public void Conversar()
    {
        if (indexDeConversaciones <= conversacionesDisponibles.Count - 1)
        {
            if (conversacionesDisponibles[indexDeConversaciones].desbloqueada)
            {
                if (conversacionesDisponibles[indexDeConversaciones].finalizado)
                {
                    if(ActualizarConversacion())
                    {
                        DialogoManager.instance.MostrarUI(true);
                        DialogoManager.instance.SetConversacion(conversacionesDisponibles[indexDeConversaciones], this);
                    }
                    DialogoManager.instance.SetConversacion(conversacionesDisponibles[indexDeConversaciones], this);
                    return;
                }
                DialogoManager.instance.MostrarUI(true);
                DialogoManager.instance.SetConversacion(conversacionesDisponibles[indexDeConversaciones], this);
            }
            else
            {
                Debug.LogWarning("La conversacion esta bloqueada");
                DialogoManager.instance.MostrarUI(false);
            }
        }
        else
        {
            print("fin del dialogo");
            DialogoManager.instance.MostrarUI(false);
        }
    }

    bool ActualizarConversacion()
    {
        if (!conversacionesDisponibles[indexDeConversaciones].reUsar)
        {
           if (indexDeConversaciones < conversacionesDisponibles.Count - 1)
           {
               indexDeConversaciones++;
               return true;
           }
           else
           {
               return false;

           } 
        }
        else
        {
            return true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DialogoManager.instance.MostrarUI(false);
            Boton.SetActive(false);
        }
    }
}

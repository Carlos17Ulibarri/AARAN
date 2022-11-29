using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogoManager : MonoBehaviour
{
   public static DialogoManager instance  {get; private set;} 
   public static DialogueSpeaker speakerActual;
   [SerializeField]
   private DialogosUI dialUI;
   [SerializeField]
   private GameObject player;
   [SerializeField]
   public Joystick joystickMove;

   public Controladorpreguntas controladorpreguntas;

   void Awake() 
   {
       if(instance == null)
       {
           instance = this;
           DontDestroyOnLoad(gameObject);
       }
       else 
       {
           Destroy(gameObject);
       }

       dialUI = FindObjectOfType<DialogosUI>(); 

       controladorpreguntas = FindObjectOfType<Controladorpreguntas>();   
   }

   private void Start()
   {
       MostrarUI(false);
       //player.GetComponent<DialogueSpeaker>().Conversar();
   }

   public void MostrarUI(bool mostrar)
   {
       dialUI.gameObject.SetActive(mostrar);

       if(!mostrar)
       {
           dialUI.localIn = 0;
           //joystickMove.SetActive(true);
       }
   }

   public void SetConversacion (Conversacion conv, DialogueSpeaker speaker)
   {
       if (speaker !=null)
       {
           speakerActual = speaker;
       }
       else
       {
           dialUI.conversacion = conv;
           dialUI.localIn = 0;
           dialUI.ActualizarTexto(0);
           

       }

       if (conv.finalizado && !conv.reUsar)
       {
           dialUI.conversacion = conv;
           dialUI.localIn = conv.dialogos.Length;
           dialUI.ActualizarTexto(1);
           

       }
       else 
       {
           dialUI.conversacion = conv;
           dialUI.localIn = speakerActual.dialLocalIn;
           dialUI.ActualizarTexto(0);
           
       }

   }
   
   public void CambiarEstadodeReUsable(Conversacion conv, bool estadoDeseado)
   {
       conv.reUsar = estadoDeseado;
   }

   public void BloqueoYDesbloqueoDeConversacion(Conversacion conv, bool desbloquear)
   {
       conv.desbloqueada = desbloquear;
   }


}

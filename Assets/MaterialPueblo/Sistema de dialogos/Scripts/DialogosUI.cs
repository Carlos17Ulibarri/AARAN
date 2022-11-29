using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro; 
using UnityEngine;

public class DialogosUI : MonoBehaviour
{
    public Conversacion conversacion;
    [SerializeField]
    private float textSpeed = 10;

    [SerializeField]
    private GameObject convContainer;
    [SerializeField]
    private GameObject pregContainer;

    [SerializeField]
    public TextMeshProUGUI nombre;
    [SerializeField]
    private TextMeshProUGUI convText;

    [SerializeField]
    public Button continuarButton;

    private AudioSource audioSourse;

    public int localIn = 1;

    private void Start() 
    {
        audioSourse = GetComponent<AudioSource>();

        convContainer.SetActive(true);
        pregContainer.SetActive(false);

        continuarButton.gameObject.SetActive(true);

    }

    public void ActualizarTexto(int comportamiento)
    {

        convContainer.SetActive(true);
        pregContainer.SetActive(false);

        switch (comportamiento)
        {
            case 0:
                print("dialogo actualizado");

                nombre.text = conversacion.dialogos[localIn].personaje.nombre;
                StopAllCoroutines();
                StartCoroutine(EscribirTexto());
                //convText.text = conversacion.dialogos[localIn].dialogo;

                if(conversacion.dialogos[localIn].sonido != null)
                {
                    audioSourse.Stop();
                    var audio = conversacion.dialogos[localIn].sonido;
                    audioSourse.PlayOneShot(audio);
                }

                if (localIn >= conversacion.dialogos.Length - 1)
                {
                    continuarButton.GetComponentInChildren<TextMeshProUGUI>().text = "<color=red>Finalizar</color>";
                }
                else
                {
                    continuarButton.GetComponentInChildren<TextMeshProUGUI>().text = "Continuar";
                }
                break;

            case 1:
                if (localIn < conversacion.dialogos.Length - 1)
                {
                    print("dialogo siguiente");
                    localIn++;
                    nombre.text = conversacion.dialogos[localIn].personaje.nombre;
                    StopAllCoroutines();
                    StartCoroutine(EscribirTexto());

                    if (conversacion.dialogos[localIn].sonido != null)
                    {
                        audioSourse.Stop();
                        var audio = conversacion.dialogos[localIn].sonido;
                        audioSourse.PlayOneShot(audio);
                    }
                    
                    if (localIn >= conversacion.dialogos.Length - 1)
                    {
                        continuarButton.GetComponentInChildren<TextMeshProUGUI>().text = "<color=red>Finalizar</color>";
                    }
                    else
                    {
                        continuarButton.GetComponentInChildren<TextMeshProUGUI>().text = "Continuar";
                    }
                }
                else 
                {
                    print("dialogo terminado");
                    localIn = 0;
                    DialogoManager.speakerActual.dialLocalIn = 0;
                    conversacion.finalizado = true;

                    if (conversacion.pregunta != null)
                    {
                        convContainer.SetActive(false);
                        pregContainer.SetActive(true);
                        var preg = conversacion.pregunta;
                        DialogoManager.instance.controladorpreguntas.ActivarBotones(preg.opciones.Length, preg.pregunta, preg.opciones);

                        return;
                    }

                    DialogoManager.instance.MostrarUI(false);
                    return;
                }

                DialogoManager.speakerActual.dialLocalIn = localIn;

                break;
            default:
                Debug.LogWarning("Estas pasando un valor no admitido(solo se aceptan estos valores: -1, 0, 1).");
                break;    
        }
    }

    IEnumerator EscribirTexto()
    {
        convText.maxVisibleCharacters = 0;
        convText.text = conversacion.dialogos[localIn].dialogo;
        convText.richText = true;
        
        for (int i = 0; i < conversacion.dialogos[localIn].dialogo.ToCharArray().Length; i++)
        {
            convText.maxVisibleCharacters++;
            yield return new WaitForSeconds(1f / textSpeed);  
        }
    }

}

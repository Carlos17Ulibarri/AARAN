using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class Mec1 : MonoBehaviour
{
    [SerializeField, TextArea(4, 6)] public string[] dm1;
                     public string Ansm1;

    [SerializeField] public Animator m1;
    [SerializeField] public AudioSource soundsm1;
    [SerializeField] public GameObject dm1panel;
    [SerializeField] public GameObject Answm1;
    [SerializeField] public GameObject bsej1;
    [SerializeField] public GameObject bsej2;
    [SerializeField] public GameObject bsej3;
    [SerializeField] public GameObject bsej4;
    [SerializeField] public GameObject bsej5;
    [SerializeField] public GameObject brestm1;
    [SerializeField] public GameObject bCmG;
    [SerializeField] public TMP_Text dm1text;

    [SerializeField] public AudioClip sdm1_1;
    [SerializeField] public AudioClip sdm1_2;
    [SerializeField] public AudioClip sdm1_3;
    [SerializeField] public AudioClip sdm1_4;
    [SerializeField] public AudioClip sdm1_5;
    [SerializeField] public AudioClip sdm1_6;
    [SerializeField] public AudioClip sdm1_7;
    [SerializeField] public AudioClip sdENDm1;
    [SerializeField] public AudioClip sdESDm1;
    [SerializeField] public AudioClip sdRcm1;
    [SerializeField] public AudioClip sdRinm1_1;
    [SerializeField] public AudioClip sdRinm1_2;
    [SerializeField] public AudioClip sdRinm1_3;
    [SerializeField] public AudioClip sdRinm1_4;
  
    // Start is called before the first frame update
    void Start()
    {
        m1.GetComponent<Animator>();
        soundsm1.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void startanim (string newstate)
    {
        m1.Play(newstate);
    }

    public void dsm1()
    {
        dm1panel.SetActive(true);
        dm1text.text = dm1[0];
        soundsm1.PlayOneShot(sdm1_1, 1.0f);
    }

    public void dsm2()
    {
        dm1text.text = dm1[1];
        soundsm1.PlayOneShot(sdm1_2, 1.0f);
    }

    public void dsm3()
    {
        dm1text.text = dm1[2];
        soundsm1.PlayOneShot(sdm1_3, 1.0f);
    }

    public void dsm4()
    {
        dm1text.text = dm1[3];
        soundsm1.PlayOneShot(sdm1_4, 1.0f);
    }

    public void dEND()
    {
        soundsm1.PlayOneShot(sdENDm1, 1.0f);
    }

    public void dESD()
    {
        soundsm1.PlayOneShot(sdESDm1, 1.0f);
    }

    public void dsmRc()
    {
        dm1text.text = dm1[4];
        soundsm1.PlayOneShot(sdRcm1, 1.0f);
    }

    public void dsmRin1()
    {
        dm1text.text = dm1[5];
        soundsm1.PlayOneShot(sdRinm1_1, 1.0f);
    }

    public void dsmRin2()
    {
        dm1text.text = dm1[6];
        soundsm1.PlayOneShot(sdRinm1_2, 1.0f);
    }

    public void dsmRin3()
    {
        dm1text.text = dm1[7];
        soundsm1.PlayOneShot(sdRinm1_3, 1.0f);
    }

    public void dsmRin4()
    {
        dm1text.text = dm1[8];
        soundsm1.PlayOneShot(sdRinm1_4, 1.0f);
    }

    public void dsm5()
    {
        dm1text.text = dm1[9];
        soundsm1.PlayOneShot(sdm1_5, 1.0f);
    }

    public void dsm6()
    {
        dm1text.text = dm1[10];
        soundsm1.PlayOneShot(sdm1_6, 1.0f);
    }

    public void dsm7()
    {
        dm1text.text = dm1[11];
        soundsm1.PlayOneShot(sdm1_7, 1.0f);
    }

    public void getAnsw(string ans)
    {
        Ansm1 = ans;
    }

    public void startej1()
    {
        dm1text.text = dm1[12];
        startanim("AM1_ej1");
    }
 
    public void ej1()
    {
        Answm1.SetActive(true);
        bsej1.SetActive(true);
        Time.timeScale = 0f;
    }

    public void pre_ej2()
    {
        if (Ansm1 == "Cero" | Ansm1 == "cero" | Ansm1 == "CERO")
        {
                Time.timeScale = 1f;
                startanim("AM1_ej1_respC");
                Answm1.SetActive(false);
        }else
        {
            Time.timeScale = 1f;
            startanim("AM1_ej1_respIn");
            Answm1.SetActive(false);
        }
    }

    public void startej2()
    {
        dm1text.text = dm1[12];
        startanim("AM1_ej2");
    }

    public void ej2()
    {
        Answm1.SetActive(true);
        bsej2.SetActive(true);
        Time.timeScale = 0f;
    }

    public void pre_ej3()
    {
        if (Ansm1 == "2")
        {
            Time.timeScale = 1f;
            startanim("AM1_ej2_respC");
            Answm1.SetActive(false);
        }
        else
        {
            Time.timeScale = 1f;
            startanim("AM1_ej2_respIn");
            Answm1.SetActive(false);
        }
    }

    public void startej3()
    {
        dm1text.text = dm1[12];
        startanim("AM1_ej3");
    }

    public void ej3()
    {
        Answm1.SetActive(true);
        bsej3.SetActive(true);
        Time.timeScale = 0f;
    }

    public void pre_ej4()
    {
        if (Ansm1 == "Cuatro" | Ansm1 == "cuatro" | Ansm1 == "CUATRO")
        {
            Time.timeScale = 1f;
            startanim("AM1_ej3_respC");
            Answm1.SetActive(false);
        }
        else
        {
            Time.timeScale = 1f;
            startanim("AM1_ej3_respIn");
            Answm1.SetActive(false);
        }
    }

    public void startej4()
    {
        dm1text.text = dm1[12];
        startanim("AM1_ej4");
    }

    public void ej4()
    {
        Answm1.SetActive(true);
        bsej4.SetActive(true);
        Time.timeScale = 0f;
    }

    public void pre_ej5()
    {
        if (Ansm1 == "6")
        {
            Time.timeScale = 1f;
            startanim("AM1_ej4_respC");
            Answm1.SetActive(false);
        }
        else
        {
            Time.timeScale = 1f;
            startanim("AM1_ej4_respIn");
            Answm1.SetActive(false);
        }
    }

    public void startej5()
    {
        dm1text.text = dm1[12];
        startanim("AM1_ej5");
    }

    public void ej5()
    {
        Answm1.SetActive(true);
        bsej5.SetActive(true);
        Time.timeScale = 0f;
    }

    public void pre_finish()
    {
        if (Ansm1 == "Ocho" | Ansm1 == "ocho" | Ansm1 == "OCHO")
        {
            Time.timeScale = 1f;
            startanim("AM1_ej5_respC");
            Answm1.SetActive(false);
        }
        else
        {
            Time.timeScale = 1f;
            startanim("AM1_ej5_respIn");
            Answm1.SetActive(false);
        }
    }

    public void seeBFinishandChangemodgame()
    {
        dm1panel.SetActive(false);
        brestm1.SetActive(true);
        bCmG.SetActive(true);
    }

    public void ChangeScenePueblo()
    {
        SceneManager.LoadScene(0);
    }

}

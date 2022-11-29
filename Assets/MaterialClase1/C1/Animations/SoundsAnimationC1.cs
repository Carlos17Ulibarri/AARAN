using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SoundsAnimationC1 : MonoBehaviour
{
    [SerializeField] public Animator c1;
    [SerializeField] public AudioSource sounds;

    [SerializeField, TextArea(4, 6)] public string[] dc1;
    [SerializeField] public GameObject dpanelc1;
    [SerializeField] public TMP_Text dtextc1;
    [SerializeField] public GameObject button_playmec1;
    [SerializeField] public GameObject button_replay;

    [SerializeField] public AudioClip sdc1_1;
    [SerializeField] public AudioClip sdc1_2;
    [SerializeField] public AudioClip sdc1_3;
    [SerializeField] public AudioClip sdc1_4;
    [SerializeField] public AudioClip sdc1_5;
    [SerializeField] public AudioClip sdc1_6;
    [SerializeField] public AudioClip sdc1_7;
    [SerializeField] public AudioClip sdc1_8;
    [SerializeField] public AudioClip sdc1_9;
    [SerializeField] public AudioClip sndc1_0;
    [SerializeField] public AudioClip sndc1_1;
    [SerializeField] public AudioClip sndc1_2;
    [SerializeField] public AudioClip sndc1_3;
    [SerializeField] public AudioClip sndc1_4;
    [SerializeField] public AudioClip sndc1_5;
    [SerializeField] public AudioClip sndc1_6;
    [SerializeField] public AudioClip sndc1_7;
    [SerializeField] public AudioClip sndc1_8;
    [SerializeField] public AudioClip sndc1_9;

    // Start is called before the first frame update
    void Start()
    {
        c1.GetComponent<Animator>();
        sounds.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sound_sdc1_1()
    {
        button_playmec1.SetActive(false);
        dpanelc1.SetActive(true);
        dtextc1.text = dc1[0];
        sounds.PlayOneShot(sdc1_1, 1.0f);

    }

    public void sound_sdc1_2()
    {
        dtextc1.text = dc1[1];
        sounds.PlayOneShot(sdc1_2, 1.0f);
    }

    public void sound_sdc1_3()
    {
        dtextc1.text = dc1[2];
        sounds.PlayOneShot(sdc1_3, 1.0f);
    }

    public void sound_sdc1_4()
    {
        dtextc1.text = dc1[3];
        sounds.PlayOneShot(sdc1_4, 1.0f);
    }

    public void sound_sdc1_5()
    {
        dtextc1.text = dc1[4];
        sounds.PlayOneShot(sdc1_5, 1.0f);
    }

    public void sound_sdc1_6()
    {
        dtextc1.text = dc1[5];
        sounds.PlayOneShot(sdc1_6, 1.0f);
    }

    public void sound_sdc1_7()
    {
        dtextc1.text = dc1[6];
        sounds.PlayOneShot(sdc1_7, 1.0f);
    }

    public void sound_sdc1_8()
    {
        dtextc1.text = dc1[7];
        sounds.PlayOneShot(sdc1_8, 1.0f);
    }

    public void sound_sdc1_9()
    {
        dtextc1.text = dc1[8];
        sounds.PlayOneShot(sdc1_9, 1.0f);
        dpanelc1.SetActive(true);
    }

    public void sound_sndc1_0()
    {
        dpanelc1.SetActive(false);
        sounds.PlayOneShot(sndc1_0, 1.0f);
    }

    public void sound_sndc1_1()
    {
        sounds.PlayOneShot(sndc1_1, 1.0f);
    }

    public void sound_sndc1_2()
    {
        sounds.PlayOneShot(sndc1_2, 1.0f);
    }

    public void sound_sndc1_3()
    {
        sounds.PlayOneShot(sndc1_3, 1.0f);
    }

    public void sound_sndc1_4()
    {
        sounds.PlayOneShot(sndc1_4, 1.0f);
    }

    public void sound_sndc1_5()
    {
        sounds.PlayOneShot(sndc1_5, 1.0f);
    }

    public void sound_sndc1_6()
    {
        sounds.PlayOneShot(sndc1_6, 1.0f);
    }

    public void sound_sndc1_7()
    {
        sounds.PlayOneShot(sndc1_7, 1.0f);
    }

    public void sound_sndc1_8()
    {
        sounds.PlayOneShot(sndc1_8, 1.0f);
    }

    public void sound_sndc1_9_1()
    {
        sounds.PlayOneShot(sndc1_9, 1.0f);
    }

    public void sound_sndc1_9_2()
    {
        sounds.PlayOneShot(sndc1_9, 1.0f);
        button_playmec1.SetActive(true);
        button_replay.SetActive(true);
    }

    public void ChangeSceneM1()
    {
        dpanelc1.SetActive(false);
        SceneManager.LoadScene(2);
    }
}

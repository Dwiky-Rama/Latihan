using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Field : MonoBehaviour
{
    public InputField nama;

    public InputField hewan;

    public Text teks;

    public void TextField()
    {
        if (nama.text == "" || hewan.text == "")
        {
            teks.text = "Lengkapilah kolom terlebih dahulu...";
        }
        else
        {
            teks.text = "Namaku " + nama.text + ", dan Hewan kesukaanku adalah " + hewan.text;
        }
    }
}

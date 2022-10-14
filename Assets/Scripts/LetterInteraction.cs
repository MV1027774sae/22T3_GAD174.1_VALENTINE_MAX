using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LetterInteraction : MonoBehaviour
{
    [SerializeField] private GameObject letter;
    public void ShowLetter()
    {
        letter.SetActive(true);
    }

    public void HideLetter()
    {
        letter.SetActive(false);
    }
}

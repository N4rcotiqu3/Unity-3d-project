using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTutoGame : MonoBehaviour
{
    public GameObject camGame;
    public GameObject camTuto;
    public GameObject bouttonOk;
    public GameObject bouttonTuto;
    public GameObject textTimer;
    public GameObject textScore;

    void Start()
    {
        bouttonOk.SetActive(false);
        bouttonTuto.SetActive(true);
    }

    public void camTutoriel()
    {
        camGame.SetActive(false);
        camTuto.SetActive(true);
        bouttonTuto.SetActive(false);
        bouttonOk.SetActive(true);
        textTimer.SetActive(false);
        textScore.SetActive(false);
    }

    public void camJeux()
    {
        camGame.SetActive(true);
        camTuto.SetActive(false);
        bouttonTuto.SetActive(true);
        bouttonOk.SetActive(false);
        textTimer.SetActive(true);
        textScore.SetActive(true);
    }
}

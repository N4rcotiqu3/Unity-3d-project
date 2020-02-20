using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectSystem1 : MonoBehaviour
{
    public static int theScore;

    public GameObject scoreText;
    public GameObject doorOpen;
    public GameObject textDoor;
    public GameObject textWin;
    
    void Start()
    {
        textWin.SetActive(false);
        textDoor.SetActive(false);
    }

    void Update()
    {
        scoreText.GetComponent<Text>().text = "Pièces : " + theScore;
        if(theScore >= 5)
        {
            Destroy(doorOpen);
            textDoor.SetActive(true);
        }
        if (theScore >=6)
        {
            textDoor.SetActive(false);
            textWin.SetActive(true);
        }
    }
}

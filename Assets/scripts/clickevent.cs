using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickevent : MonoBehaviour
{
    public void restartScene()
    {
        SceneManager.LoadScene("MiniGame");
    }
}

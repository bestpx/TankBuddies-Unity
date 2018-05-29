using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TankBuddies.UI
{

    public class MainMenuUIView : MonoBehaviour
    {
        public void OnStartButtonClicked()
        {
            SceneManager.LoadScene("Lobby");
        }

        public void OnQuitButtonClicked()
        {
            Application.Quit();
        }
    }

}

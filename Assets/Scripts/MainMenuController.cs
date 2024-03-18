using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        int selectedCharacter = int.Parse(EventSystem.current.currentSelectedGameObject.name);

        GameManager.instance.charIndex = selectedCharacter;

        SceneManager.LoadScene("Gameplay");
    }
}

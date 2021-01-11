using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Button))]
public class GotoScene : MonoBehaviour, IPointerClickHandler
{
    private enum AvailableScenes
    {
        SceneA = 0,
        SceneB = 1,
        SceneC = 2
    }
    
    [SerializeField] private AvailableScenes _scene;

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene((int) _scene);
    }
}

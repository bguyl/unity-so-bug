using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Button))]
public class GotoSceneAddressable : MonoBehaviour, IPointerClickHandler
{
	[SerializeField] private AssetReference _scene;

	public void OnPointerClick(PointerEventData eventData)
	{
		SceneOrchestration.LoadScene(_scene);
	}
}
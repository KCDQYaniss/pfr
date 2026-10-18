namespace EFT.UI;

public sealed class LoadingIndicator : MonoBehaviour
{
	[SerializeField]
	private RectTransform _spinner; //Field offset: 0x20
	[SerializeField]
	private TMP_Text _text; //Field offset: 0x28
	[SerializeField]
	private TMP_Text _dots; //Field offset: 0x30
	private int _lastTime; //Field offset: 0x38

	public LoadingIndicator() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void RemoveDotsFromText() { }

	private void Update() { }

}


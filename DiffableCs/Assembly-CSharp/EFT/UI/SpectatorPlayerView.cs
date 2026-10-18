namespace EFT.UI;

public class SpectatorPlayerView : MonoBehaviour
{
	[SerializeField]
	private Image _icon; //Field offset: 0x20
	[SerializeField]
	private GameObject[] _deadElements; //Field offset: 0x28
	[SerializeField]
	private GameObject[] _selectedElements; //Field offset: 0x30

	public SpectatorPlayerView() { }

	public void SetDead(bool dead) { }

	public void SetIcon(Sprite sprite) { }

	public void SetSelected(bool selected) { }

}


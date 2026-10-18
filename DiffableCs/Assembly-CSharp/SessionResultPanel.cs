//Type is in global namespace

public class SessionResultPanel : MonoBehaviour
{
	[SerializeField]
	private Sprite _icon; //Field offset: 0x20
	[SerializeField]
	private Sprite _glow; //Field offset: 0x28
	[SerializeField]
	private Image _iconImage; //Field offset: 0x30
	[SerializeField]
	private Image _glowImage; //Field offset: 0x38

	public SessionResultPanel() { }

	private void Awake() { }

}


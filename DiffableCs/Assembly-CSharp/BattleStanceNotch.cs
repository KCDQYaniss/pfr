//Type is in global namespace

public class BattleStanceNotch : MonoBehaviour
{
	[SerializeField]
	private Color _availableColor; //Field offset: 0x20
	[SerializeField]
	private Color _unavailableColor; //Field offset: 0x30
	[SerializeField]
	private Image _notchImage; //Field offset: 0x40

	public BattleStanceNotch() { }

	public void Init(RectTransform rect) { }

	public void Show(bool available) { }

}


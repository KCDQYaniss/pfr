//Type is in global namespace

public class BotInfoIcon : MonoBehaviour
{
	[SerializeField]
	private Image _icon; //Field offset: 0x20
	[SerializeField]
	private Color _trueColor; //Field offset: 0x28
	[SerializeField]
	private Color _falseColor; //Field offset: 0x38
	[SerializeField]
	private List _additionalColors; //Field offset: 0x48
	private bool _boolValue; //Field offset: 0x50
	private int _intValue; //Field offset: 0x54

	public BotInfoIcon() { }

	public void SetBool(bool value) { }

	public void SetColor(Color color) { }

	public void SetInt(int value) { }

}


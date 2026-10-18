namespace Arena.UI;

public class FaceCardView : MonoBehaviour
{
	[SerializeField]
	private TMP_Text _label; //Field offset: 0x20
	[SerializeField]
	private Toggle _toggle; //Field offset: 0x28
	[SerializeField]
	private ArenaToggleStateToImageColor _arenaToggleStateToImageColorDictionary; //Field offset: 0x30
	[SerializeField]
	private List _stateColors; //Field offset: 0x38
	[SerializeField]
	private Image[] _glows; //Field offset: 0x40
	[SerializeField]
	private Image[] _shadows; //Field offset: 0x48
	[SerializeField]
	private PlayerIconImage _playerIconImage; //Field offset: 0x50
	[CompilerGenerated]
	private Action _onSelected; //Field offset: 0x58
	private int _callbackValue; //Field offset: 0x60
	private bool _isSelected; //Field offset: 0x64

	private event Action _onSelected
	{
		[CompilerGenerated]
		private add { } //Length: 262
		[CompilerGenerated]
		private remove { } //Length: 262
	}

	public FaceCardView() { }

	[CompilerGenerated]
	private void add__onSelected(Action value) { }

	public void Init(string faceName, InventoryEquipment inventoryEquipment, BodyCustomization customization, ToggleGroup toggleGroup, int callbackValue, Action callback, bool isSelected) { }

	private void PoiterEventHandler(bool isEnter) { }

	[CompilerGenerated]
	private void remove__onSelected(Action value) { }

	private void SetListener(Action listener) { }

	private void SetSelected(bool isSelected) { }

	private void SetVisual(EToggleState toggleState) { }

}


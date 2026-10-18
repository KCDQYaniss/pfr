namespace EFT.UI;

public sealed class EditTagWindow : Window, IRemoveHandler, IItemRelatedView
{
	private const string SYMBOLS_COUNTER_TEMPLATE = "{0}/{1}"; //Field offset: 0x0
	private const string CONTAINER_TAG_TEMPLATE = "container tag"; //Field offset: 0x0
	[SerializeField]
	private ValidationInputField _tagInput; //Field offset: 0xB8
	[SerializeField]
	private TextMeshProUGUI _simbolsCounter; //Field offset: 0xC0
	[SerializeField]
	private DefaultUIButton _saveButtonSpawner; //Field offset: 0xC8
	[SerializeField]
	private TextMeshProUGUI _containerTagLabel; //Field offset: 0xD0
	[SerializeField]
	private TagColorsPanel _colorsPanel; //Field offset: 0xD8
	private TagComponent _tag; //Field offset: 0xE0
	private IItemOwner _owner; //Field offset: 0xE8
	private ColorView _selectedColorView; //Field offset: 0xF0
	private int _selectedColorIndex; //Field offset: 0xF8

	public EditTagWindow() { }

	public virtual void Close() { }

	private void ColorSelectedHandler(ColorView cell, int colorIndex) { }

	private override void EFT.IRemoveHandler.OnItemRemoved(RemoveItemEventArgs obj) { }

	public static Color GetColor(int colorIndex) { }

	private void Save() { }

	public EditTagWindowContext Show(TagComponent tagComponent) { }

	private void TagTextChange(string newText) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}


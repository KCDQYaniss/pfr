namespace EFT.UI;

public sealed class DialogStartButton : UIElement
{
	[SerializeField]
	private DefaultUIButton _defaultUIButton; //Field offset: 0x70
	[SerializeField]
	private GameObject _normalObject; //Field offset: 0x78
	[SerializeField]
	private GameObject _attentionObject; //Field offset: 0x80
	[CompilerGenerated]
	private Action OnClick; //Field offset: 0x88

	public event Action OnClick
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public DialogStartButton() { }

	[CompilerGenerated]
	public void add_OnClick(Action value) { }

	private void Awake() { }

	public void Init(bool interactable, bool attention) { }

	private void OnClickHandler() { }

	[CompilerGenerated]
	public void remove_OnClick(Action value) { }

}


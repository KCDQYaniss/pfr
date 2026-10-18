namespace EFT.UI;

[UsedImplicitly]
public sealed class DialogTreeView : UIElement
{
	public static readonly Color32 UserColor; //Field offset: 0x0
	public static readonly Color32 TraderColor; //Field offset: 0x4
	[SerializeField]
	[UsedImplicitly]
	private Button _playButton; //Field offset: 0x70
	[SerializeField]
	[UsedImplicitly]
	private DialogPlayerView _dialogPlayer; //Field offset: 0x78
	[SerializeField]
	[UsedImplicitly]
	private Button _saveButton; //Field offset: 0x80
	[SerializeField]
	[UsedImplicitly]
	private Button _loadButton; //Field offset: 0x88
	[SerializeField]
	[UsedImplicitly]
	private Button _importButton; //Field offset: 0x90
	private TraderDialogTemplate _dialog; //Field offset: 0x98

	private static DialogTreeView() { }

	public DialogTreeView() { }

	[CompilerGenerated]
	private void <Show>b__9_0() { }

	[UsedImplicitly]
	private void Awake() { }

	private void ImportClickHandler() { }

	private void LoadClickHandler() { }

	private void SaveClickHandler() { }

	private void Show(TraderDialogTemplate dialog = null) { }

}


namespace EFT.Vaulting.Debug.View.Pages;

public class RestrictionsPageView : IVaultingDebugPageView
{
	private string _minDistantToVault; //Field offset: 0x10
	private string _minVaultHeight; //Field offset: 0x18
	private string _maxVaultHeight; //Field offset: 0x20
	private string _minVaultLength; //Field offset: 0x28
	private string _maxVaultLength; //Field offset: 0x30
	private string _minClimbHeight; //Field offset: 0x38
	private string _maxClimbHeight; //Field offset: 0x40
	private string _minClimbLength; //Field offset: 0x48
	private string _maxClimbLength; //Field offset: 0x50
	private bool _isSubmitButtonClick; //Field offset: 0x58
	private bool _isBackButtonClick; //Field offset: 0x59
	private bool _isInputBadData; //Field offset: 0x5A
	private bool _isSuccsessUpdateData; //Field offset: 0x5B
	private readonly PageViewer _mainView; //Field offset: 0x60
	[CompilerGenerated]
	private Action OnClickSubmitButton; //Field offset: 0x68
	[CompilerGenerated]
	private Action OnClickBackButton; //Field offset: 0x70

	public event Action OnClickBackButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnClickSubmitButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public RestrictionsPageView(PageViewer view) { }

	[CompilerGenerated]
	public void add_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public void add_OnClickSubmitButton(Action value) { }

	private void CheckActions() { }

	private void DrawDistanceSettingsTable() { }

	private GUIStyle GetBadDataStyle() { }

	private GUIStyle GetHeaderStyle() { }

	private GUIStyle GetInputFieldStyle() { }

	private GUIStyle GetParameterStyle() { }

	private GUIStyle GetSuccsessDataStyle() { }

	[CompilerGenerated]
	public void remove_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public void remove_OnClickSubmitButton(Action value) { }

	public override void SetAsCurrent() { }

	public void SetInitialRestrictions(VaultingRestrictionsPageModel model) { }

	public override void Show() { }

	public bool TryUpdateVaultingRestrictions(out VaultingRestrictionsPageModel model) { }

}


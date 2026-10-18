namespace EFT.Vaulting.Debug.View;

public class AutomaticVaultingPageView : IAutomaticVaultingPageView, IVaultingDebugPageView
{
	private readonly PageViewer _pageViewer; //Field offset: 0x10
	private string _minHeightToVault; //Field offset: 0x18
	private string _maxHeightToVault; //Field offset: 0x20
	private string _minLengthToVault; //Field offset: 0x28
	private string _maxLengthToVault; //Field offset: 0x30
	private string _minHeightToClimb; //Field offset: 0x38
	private string _maxHeightToClimb; //Field offset: 0x40
	private string _minLengthToClimb; //Field offset: 0x48
	private string _maxLengthToClimb; //Field offset: 0x50
	private bool _isAutomaticVault; //Field offset: 0x58
	private bool _isAutomaticClimb; //Field offset: 0x59
	private bool _cachedIsAutomaticVault; //Field offset: 0x5A
	private bool _cachedIsAutomaticClimb; //Field offset: 0x5B
	private bool _isInputBadData; //Field offset: 0x5C
	private bool _isSuccsessUpdateData; //Field offset: 0x5D
	private bool _isSubmitButtonClick; //Field offset: 0x5E
	private bool _isBackButtonClicked; //Field offset: 0x5F
	[CompilerGenerated]
	private Action OnClickAutomaticVaultToggle; //Field offset: 0x60
	[CompilerGenerated]
	private Action OnClickAutomaticClimbToggle; //Field offset: 0x68
	[CompilerGenerated]
	private Action OnClickBackButton; //Field offset: 0x70
	[CompilerGenerated]
	private Action OnClickSublitButton; //Field offset: 0x78

	public override event Action OnClickAutomaticClimbToggle
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnClickAutomaticVaultToggle
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnClickBackButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event Action OnClickSublitButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public AutomaticVaultingPageView(PageViewer pageViewer) { }

	[CompilerGenerated]
	public override void add_OnClickAutomaticClimbToggle(Action value) { }

	[CompilerGenerated]
	public override void add_OnClickAutomaticVaultToggle(Action value) { }

	[CompilerGenerated]
	public override void add_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public override void add_OnClickSublitButton(Action value) { }

	private void CheckActions() { }

	private void DrawClimbRestrictions() { }

	private void DrawSettingsTable() { }

	private void DrawToggleSection() { }

	private void DrawVaultRestrictions() { }

	private GUIStyle GetBadDataStyle() { }

	private GUIStyle GetHeaderStyle() { }

	private GUIStyle GetInputFieldStyle() { }

	private GUIStyle GetParameterStyle() { }

	private GUIStyle GetSuccsessDataStyle() { }

	private GUIStyle GetToggleStyle() { }

	[CompilerGenerated]
	public override void remove_OnClickAutomaticClimbToggle(Action value) { }

	[CompilerGenerated]
	public override void remove_OnClickAutomaticVaultToggle(Action value) { }

	[CompilerGenerated]
	public override void remove_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public override void remove_OnClickSublitButton(Action value) { }

	public override void SetAsCurrent() { }

	public override void SetParameters(AutomaticVaultingDataModel model) { }

	public override void Show() { }

	public override bool TryUpdateGridOptions(out AutomaticVaultingDataModel model) { }

}


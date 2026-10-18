namespace EFT.Vaulting.Debug.View;

public class GridOptionsPageView : IVaultingDebugPageView
{
	private readonly PageViewer _mainView; //Field offset: 0x10
	private string _gridSizeX; //Field offset: 0x18
	private string _gridSizeY; //Field offset: 0x20
	private string _gridSizeZ; //Field offset: 0x28
	private string _steppingLengthX; //Field offset: 0x30
	private string _steppingLengthY; //Field offset: 0x38
	private string _steppingLengthZ; //Field offset: 0x40
	private string _gridOffsetX; //Field offset: 0x48
	private string _gridOffsetY; //Field offset: 0x50
	private string _gridOffsetZ; //Field offset: 0x58
	private string _offsetFactor; //Field offset: 0x60
	private bool _isSubmitButtonClick; //Field offset: 0x68
	private bool _isBackButtonClick; //Field offset: 0x69
	private bool _isInputBadData; //Field offset: 0x6A
	private bool _isSuccsessUpdateData; //Field offset: 0x6B
	[CompilerGenerated]
	private Action OnClickSubmitButton; //Field offset: 0x70
	[CompilerGenerated]
	private Action OnClickBackButton; //Field offset: 0x78

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

	public GridOptionsPageView(PageViewer view) { }

	[CompilerGenerated]
	public void add_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public void add_OnClickSubmitButton(Action value) { }

	private void CheckActions() { }

	private void DrawDynamicGridOffsetSettingsTable() { }

	private void DrawGridOffsetSettingsTable() { }

	private void DrawGridSizeSettingsTable() { }

	private void DrawGridSteppingSettingsTable() { }

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

	public void SetInitialParameters(GridOptionsDataModel model) { }

	public override void Show() { }

	public bool TryUpdateGridOptions(out GridOptionsDataModel model) { }

}


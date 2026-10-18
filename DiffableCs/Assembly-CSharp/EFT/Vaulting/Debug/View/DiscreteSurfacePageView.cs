namespace EFT.Vaulting.Debug.View;

public class DiscreteSurfacePageView : IDiscreteSurfacePageView, IVaultingDebugPageView
{
	private readonly PageViewer _mainView; //Field offset: 0x10
	private string _maxHeightOffset; //Field offset: 0x18
	private string _slopeThreshold; //Field offset: 0x20
	private string _rectangleThreshold; //Field offset: 0x28
	private bool _isSubmitButtonClick; //Field offset: 0x30
	private bool _isBackButtonClick; //Field offset: 0x31
	private bool _isInputBadData; //Field offset: 0x32
	private bool _isSuccsessUpdateData; //Field offset: 0x33
	[CompilerGenerated]
	private Action OnNeedUpdateData; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnClickSubmitButton; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnClickBackButton; //Field offset: 0x48

	public override event Action OnClickBackButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event Action OnClickSubmitButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event Action OnNeedUpdateData
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public DiscreteSurfacePageView(PageViewer mainView) { }

	[CompilerGenerated]
	public override void add_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public override void add_OnClickSubmitButton(Action value) { }

	[CompilerGenerated]
	public override void add_OnNeedUpdateData(Action value) { }

	private void CheckActions() { }

	private void DrawDiscreteSurfaceInfo(float distance, float height, float length, string type) { }

	private void DrawSettingsTable() { }

	private GUIStyle GetBadDataStyle() { }

	private GUIStyle GetHeaderStyle() { }

	private GUIStyle GetInputFieldStyle() { }

	private GUIStyle GetParameterStyle() { }

	private GUIStyle GetSuccsessDataStyle() { }

	[CompilerGenerated]
	public override void remove_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public override void remove_OnClickSubmitButton(Action value) { }

	[CompilerGenerated]
	public override void remove_OnNeedUpdateData(Action value) { }

	public override void SetAsCurrent() { }

	public override void SetParameters(DiscreteSurfaceDataModel model) { }

	public override void Show() { }

	public override bool TryUpdateGridOptions(out DiscreteSurfaceDataModel model) { }

}


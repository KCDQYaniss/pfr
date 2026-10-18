namespace EFT.Vaulting.Debug.View;

public class ApproximationPageView : IApproximationVaultingPageView, IVaultingDebugPageView
{
	private readonly PageViewer _pageViewer; //Field offset: 0x10
	private string _approximationTolerance; //Field offset: 0x18
	private bool _isBackButtonClicked; //Field offset: 0x20
	private bool _isSubmitButtonClick; //Field offset: 0x21
	private bool _isInputBadData; //Field offset: 0x22
	private bool _isSuccsessUpdateData; //Field offset: 0x23
	[CompilerGenerated]
	private Action OnClickSubmitButtonEvent; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnClickBackButtonEvent; //Field offset: 0x30

	public override event Action OnClickBackButtonEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event Action OnClickSubmitButtonEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public ApproximationPageView(PageViewer pageViewer) { }

	[CompilerGenerated]
	public override void add_OnClickBackButtonEvent(Action value) { }

	[CompilerGenerated]
	public override void add_OnClickSubmitButtonEvent(Action value) { }

	private void CheckActions() { }

	private void DrawSettingsTable() { }

	private GUIStyle GetBadDataStyle() { }

	private GUIStyle GetHeaderStyle() { }

	private GUIStyle GetInputFieldStyle() { }

	private GUIStyle GetParameterStyle() { }

	private GUIStyle GetSuccsessDataStyle() { }

	private GUIStyle GetToggleStyle() { }

	[CompilerGenerated]
	public override void remove_OnClickBackButtonEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_OnClickSubmitButtonEvent(Action value) { }

	public override void SetAsCurrent() { }

	public override void SetParameters(ApproximationVaultingDataModel model) { }

	public override void Show() { }

	public override bool TryToApplyParameters(out ApproximationVaultingDataModel newModel) { }

}


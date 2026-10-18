namespace EFT.Vaulting.Debug.View.Pages;

public class MainInfoPageView : IVaultingDebugPageView
{
	private readonly PageViewer _mainView; //Field offset: 0x10
	private Nullable _averageHeight; //Field offset: 0x18
	private Nullable _averageLength; //Field offset: 0x20
	private Nullable _averageDistance; //Field offset: 0x28
	private Nullable _currentMotion; //Field offset: 0x30
	private Nullable _verticalOffset; //Field offset: 0x40
	private bool _isBackButtonClicked; //Field offset: 0x48
	[CompilerGenerated]
	private Action OnClickBackButton; //Field offset: 0x50
	[CompilerGenerated]
	private Action OnNeedUpdateData; //Field offset: 0x58

	public event Action OnClickBackButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnNeedUpdateData
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public MainInfoPageView(PageViewer pageViewer) { }

	[CompilerGenerated]
	public void add_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public void add_OnNeedUpdateData(Action value) { }

	private void CheckEvents() { }

	private void DrawMotionParametersTable() { }

	private void DrawObstacleParametersTable() { }

	private GUIStyle GetMotionHeaderStyle() { }

	private GUIStyle GetParametersStyle() { }

	private GUIStyle GetSurfaceHeaderStyle() { }

	[CompilerGenerated]
	public void remove_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public void remove_OnNeedUpdateData(Action value) { }

	public override void SetAsCurrent() { }

	public override void Show() { }

	public void UpdateMotionParameters(MotionParameters model) { }

	public void UpdateSurfaceParameters(SurfaceParameters model) { }

}


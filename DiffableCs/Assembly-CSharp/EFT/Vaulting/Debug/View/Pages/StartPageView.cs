namespace EFT.Vaulting.Debug.View.Pages;

public class StartPageView : IVaultingDebugPageView
{
	private readonly PageViewer _mainView; //Field offset: 0x10
	private bool _buttonShowGridOptions; //Field offset: 0x18
	private bool _buttonShowVaultingOptions; //Field offset: 0x19
	private bool _buttonShowMainInfo; //Field offset: 0x1A
	private bool _buttonDiscreteSurfaceOptions; //Field offset: 0x1B
	private bool _buttonAutomaticVaultingOptions; //Field offset: 0x1C
	private bool _buttonApproximationVaultingOptions; //Field offset: 0x1D
	[CompilerGenerated]
	private Action OnClickShowGridOptionsButton; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnClickShowVaultingOptionsButton; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnClickShowMainInfoButton; //Field offset: 0x30
	[CompilerGenerated]
	private Action OnClickDiscreteSurfaceOptionsButton; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnClickAutomaticVaultingOptionsButton; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnClickApproximationVaultingOptionsButton; //Field offset: 0x48

	public event Action OnClickApproximationVaultingOptionsButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnClickAutomaticVaultingOptionsButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnClickDiscreteSurfaceOptionsButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnClickShowGridOptionsButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnClickShowMainInfoButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnClickShowVaultingOptionsButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public StartPageView(PageViewer mainView) { }

	[CompilerGenerated]
	public void add_OnClickApproximationVaultingOptionsButton(Action value) { }

	[CompilerGenerated]
	public void add_OnClickAutomaticVaultingOptionsButton(Action value) { }

	[CompilerGenerated]
	public void add_OnClickDiscreteSurfaceOptionsButton(Action value) { }

	[CompilerGenerated]
	public void add_OnClickShowGridOptionsButton(Action value) { }

	[CompilerGenerated]
	public void add_OnClickShowMainInfoButton(Action value) { }

	[CompilerGenerated]
	public void add_OnClickShowVaultingOptionsButton(Action value) { }

	private void CheckEvents() { }

	private GUIStyle GetButtonStyle() { }

	[CompilerGenerated]
	public void remove_OnClickApproximationVaultingOptionsButton(Action value) { }

	[CompilerGenerated]
	public void remove_OnClickAutomaticVaultingOptionsButton(Action value) { }

	[CompilerGenerated]
	public void remove_OnClickDiscreteSurfaceOptionsButton(Action value) { }

	[CompilerGenerated]
	public void remove_OnClickShowGridOptionsButton(Action value) { }

	[CompilerGenerated]
	public void remove_OnClickShowMainInfoButton(Action value) { }

	[CompilerGenerated]
	public void remove_OnClickShowVaultingOptionsButton(Action value) { }

	public override void SetAsCurrent() { }

	public override void Show() { }

}


namespace EFT.Vaulting.Debug.Controller.PageControllers;

public class StartPageController : IVaultingDebugPageController
{
	private readonly StartPageView _startPageView; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnClickGridOptionsButton; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnClickVaultingOptionsButton; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnClickMainInfoButton; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnClickDiscreteSurfaceButton; //Field offset: 0x30
	[CompilerGenerated]
	private Action OnClickAutoVaultingButton; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnClickApproximationVaultingButton; //Field offset: 0x40

	public event Action OnClickApproximationVaultingButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnClickAutoVaultingButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnClickDiscreteSurfaceButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnClickGridOptionsButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnClickMainInfoButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnClickVaultingOptionsButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public StartPageController(StartPageView startPageView) { }

	[CompilerGenerated]
	public void add_OnClickApproximationVaultingButton(Action value) { }

	[CompilerGenerated]
	public void add_OnClickAutoVaultingButton(Action value) { }

	[CompilerGenerated]
	public void add_OnClickDiscreteSurfaceButton(Action value) { }

	[CompilerGenerated]
	public void add_OnClickGridOptionsButton(Action value) { }

	[CompilerGenerated]
	public void add_OnClickMainInfoButton(Action value) { }

	[CompilerGenerated]
	public void add_OnClickVaultingOptionsButton(Action value) { }

	protected virtual void Finalize() { }

	[CompilerGenerated]
	public void remove_OnClickApproximationVaultingButton(Action value) { }

	[CompilerGenerated]
	public void remove_OnClickAutoVaultingButton(Action value) { }

	[CompilerGenerated]
	public void remove_OnClickDiscreteSurfaceButton(Action value) { }

	[CompilerGenerated]
	public void remove_OnClickGridOptionsButton(Action value) { }

	[CompilerGenerated]
	public void remove_OnClickMainInfoButton(Action value) { }

	[CompilerGenerated]
	public void remove_OnClickVaultingOptionsButton(Action value) { }

	public override void SetAsCurrent() { }

	private void ShowApproximationVaultingOptions() { }

	private void ShowAutoVaultingOptions() { }

	private void ShowDiscreteSurfaceOptions() { }

	private void ShowGridOptions() { }

	private void ShowMainInfo() { }

	private void ShowVaultingOptions() { }

	private void Subscribe() { }

	private void Unsubscribe() { }

}


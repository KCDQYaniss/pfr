namespace EFT.Vaulting.Debug.Controller;

public class ApproximationPageController
{
	private readonly IApproximationVaultingPageView _view; //Field offset: 0x10
	private readonly ISurfaceApproximatorModelDebug _model; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnClickBackButtonEvent; //Field offset: 0x20

	public event Action OnClickBackButtonEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public ApproximationPageController(IApproximationVaultingPageView view, ISurfaceApproximatorModelDebug model) { }

	[CompilerGenerated]
	public void add_OnClickBackButtonEvent(Action value) { }

	protected virtual void Finalize() { }

	private void OnClickBackButton() { }

	private void OnClickSubmitButton() { }

	[CompilerGenerated]
	public void remove_OnClickBackButtonEvent(Action value) { }

	public void SetAsCurrent() { }

	private void SetInitialParameters() { }

	private void Subscribe() { }

	private void Unsubscribe() { }

}


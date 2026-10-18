namespace EFT.Vaulting.Debug.Controller;

public class AutomaticVaultingPageController
{
	private readonly IAutomaticVaultingModelDebug _model; //Field offset: 0x10
	private readonly IAutomaticVaultingPageView _view; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnClickBackButton; //Field offset: 0x20

	public event Action OnClickBackButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public AutomaticVaultingPageController(IAutomaticVaultingModelDebug model, IAutomaticVaultingPageView view) { }

	[CompilerGenerated]
	public void add_OnClickBackButton(Action value) { }

	private void ClickAutoClimbToggle(bool value) { }

	private void ClickAutoVaultToggle(bool value) { }

	private void ClickBackButton() { }

	private void ClickSubmitButton() { }

	protected virtual void Finalize() { }

	[CompilerGenerated]
	public void remove_OnClickBackButton(Action value) { }

	public void SetAsCurrent() { }

	private void SetInitialParameters() { }

	private void Subscribe() { }

	private void Unsubscribe() { }

	private void UpdateAutoVaultingOptions() { }

}


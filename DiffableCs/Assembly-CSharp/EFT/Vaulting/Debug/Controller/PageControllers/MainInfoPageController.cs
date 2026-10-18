namespace EFT.Vaulting.Debug.Controller.PageControllers;

public class MainInfoPageController : IVaultingDebugPageController
{
	private readonly MainInfoPageView _mainInfoPageView; //Field offset: 0x10
	private readonly IVaultingModelDebug _model; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnClickBackButton; //Field offset: 0x20

	public event Action OnClickBackButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public MainInfoPageController(MainInfoPageView mainInfoPageView, IVaultingModelDebug model) { }

	[CompilerGenerated]
	private void <Subscribe>b__8_0() { }

	[CompilerGenerated]
	private void <Unsubscribe>b__9_0() { }

	[CompilerGenerated]
	public void add_OnClickBackButton(Action value) { }

	protected virtual void Finalize() { }

	[CompilerGenerated]
	public void remove_OnClickBackButton(Action value) { }

	public override void SetAsCurrent() { }

	private void Subscribe() { }

	private void Unsubscribe() { }

	private void UpdateData() { }

}


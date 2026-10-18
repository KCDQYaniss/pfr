namespace EFT.Vaulting.Debug.Controller;

public class DiscreteSurfacePageController : IDiscreteSurfacePageController
{
	private readonly IObstacleCalculatorModelDebug _model; //Field offset: 0x10
	private readonly IDiscreteSurfacePageView _view; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnParametersChanged; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnClickBackButton; //Field offset: 0x28

	public override event Action OnClickBackButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event Action OnParametersChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public DiscreteSurfacePageController(IObstacleCalculatorModelDebug model, IDiscreteSurfacePageView view) { }

	[CompilerGenerated]
	private void <Subscribe>b__10_0() { }

	[CompilerGenerated]
	private void <Unsubscribe>b__11_0() { }

	[CompilerGenerated]
	public override void add_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public override void add_OnParametersChanged(Action value) { }

	protected virtual void Finalize() { }

	[CompilerGenerated]
	public override void remove_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public override void remove_OnParametersChanged(Action value) { }

	public override void SetAsCurrent() { }

	private void SetInitialParameters() { }

	private void Subscribe() { }

	private void Unsubscribe() { }

	private void UpdateDiscreteSurfaceOptions() { }

}


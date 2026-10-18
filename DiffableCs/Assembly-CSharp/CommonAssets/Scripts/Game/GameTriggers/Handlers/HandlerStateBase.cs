namespace CommonAssets.Scripts.Game.GameTriggers.Handlers;

public abstract class HandlerStateBase : MonoBehaviour
{

	public abstract event Action StateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	protected HandlerStateBase() { }

	[CompilerGenerated]
	public abstract void add_StateChanged(Action value) { }

	public abstract void ApplyState(bool state) { }

	[CompilerGenerated]
	public abstract void remove_StateChanged(Action value) { }

}


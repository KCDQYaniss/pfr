namespace EFT.UI;

public abstract class LoadAmmoContextInteractions : ContextInteractions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public string ammoType; //Field offset: 0x10
		public LoadAmmoContextInteractions <>4__this; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal void <.ctor>b__0() { }

	}

	[CompilerGenerated]
	private struct <LoadAmmo>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LoadAmmoContextInteractions <>4__this; //Field offset: 0x20
		public string ammoTemplateId; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum EInteraction
	{
		NoCompatibleAmmo = 0,
	}

	private readonly bool _hasCompatibleAmmo; //Field offset: 0x38

	public virtual bool HasIcons
	{
		 get { } //Length: 3
	}

	protected LoadAmmoContextInteractions(Dictionary compatibleAmmo, ItemUiContext uiContext) { }

	protected virtual void ExecuteInteractionInternal(EInteraction interaction) { }

	public virtual bool get_HasIcons() { }

	public virtual bool IsActive(EInteraction button) { }

	public virtual IResult IsInteractive(EInteraction button) { }

	protected abstract Task Load(string ammoTemplateId) { }

	[AsyncStateMachine(typeof(<LoadAmmo>d__10))]
	private Task LoadAmmo(string ammoTemplateId) { }

	protected override bool ShouldRedraw(string ammoTemplateId) { }

}


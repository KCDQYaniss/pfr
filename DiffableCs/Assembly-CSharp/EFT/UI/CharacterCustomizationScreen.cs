namespace EFT.UI;

public sealed class CharacterCustomizationScreen : UIElement
{
	[CompilerGenerated]
	private struct <ApplyChanges>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CharacterCustomizationScreen <>4__this; //Field offset: 0x20
		public IEftSession session; //Field offset: 0x28
		public Profile profile; //Field offset: 0x30
		private Dictionary <customizations>5__2; //Field offset: 0x38
		private Task <applyTask>5__3; //Field offset: 0x40
		private object <>7__wrap3; //Field offset: 0x48
		private int <>7__wrap4; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Rollback>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Dictionary customizations; //Field offset: 0x20
		public CharacterCustomizationScreen <>4__this; //Field offset: 0x28
		public Profile profile; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class CharacterCustomizationTabController : UIElementTabController
	{
		private readonly Profile _profile; //Field offset: 0x18
		private readonly IEftSession _session; //Field offset: 0x20

		public CharacterCustomizationTabController(CharacterCustomizationScreen content, Profile profile, IEftSession session) { }

		public virtual void Show() { }

		public virtual Task TryHide() { }

	}

	[SerializeField]
	private AppearanceSelector _appearanceSelector; //Field offset: 0x70
	[CompilerGenerated]
	private Action OnCustomizationRollback; //Field offset: 0x78
	private Profile _profile; //Field offset: 0x80
	private IEftSession _session; //Field offset: 0x88
	private BodyCustomization _confirmedCustomization; //Field offset: 0x90
	private BodyCustomization _submittedCustomization; //Field offset: 0x98
	private readonly Dictionary _pendingCustomizations; //Field offset: 0xA0
	private Task _applyChangesTask; //Field offset: 0xA8

	public event Action OnCustomizationRollback
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public CharacterCustomizationScreen() { }

	[CompilerGenerated]
	private void <Show>b__11_0() { }

	[CompilerGenerated]
	private void <Show>b__11_1() { }

	[CompilerGenerated]
	public void add_OnCustomizationRollback(Action value) { }

	public void ApplyChanges() { }

	[AsyncStateMachine(typeof(<ApplyChanges>d__16))]
	private Task ApplyChanges(Profile profile, IEftSession session) { }

	public virtual void Close() { }

	private void Confirm(Dictionary customizations) { }

	private void HeadSelectedHandler(MongoID headId) { }

	[CompilerGenerated]
	public void remove_OnCustomizationRollback(Action value) { }

	[AsyncStateMachine(typeof(<Rollback>d__19))]
	private Task Rollback(Profile profile, Dictionary customizations) { }

	private void SelectCustomization(EBodyModelPart bodyPart, MongoID customizationId, ECustomizationType customizationType) { }

	public void Show(Profile profile, IEftSession session) { }

	private void Submit(Dictionary customizations) { }

	private void VoiceSelectedHandler(MongoID voiceId) { }

}


namespace EFT;

public sealed class DummyPlayerInputTranslator : IPlayerInputTranslator
{
	[CompilerGenerated]
	private Action OnMumbleStatusChanged; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnMakeBindAction; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnMumbleDropdownStatusChanged; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnQuickMumble; //Field offset: 0x28

	public override event Action OnMakeBindAction
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnMumbleDropdownStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnMumbleStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnQuickMumble
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public DummyPlayerInputTranslator() { }

	[CompilerGenerated]
	public override void add_OnMakeBindAction(Action value) { }

	[CompilerGenerated]
	public override void add_OnMumbleDropdownStatusChanged(Action value) { }

	[CompilerGenerated]
	public override void add_OnMumbleStatusChanged(Action value) { }

	[CompilerGenerated]
	public override void add_OnQuickMumble(Action value) { }

	[CompilerGenerated]
	public override void remove_OnMakeBindAction(Action value) { }

	[CompilerGenerated]
	public override void remove_OnMumbleDropdownStatusChanged(Action value) { }

	[CompilerGenerated]
	public override void remove_OnMumbleStatusChanged(Action value) { }

	[CompilerGenerated]
	public override void remove_OnQuickMumble(Action value) { }

	public override void TranslateAxes(ref float[] axes) { }

	public override ETranslateResult TranslateCommand(ECommand command) { }

	private void UseRecorder() { }

}


namespace EFT;

public class IntroActionsEventConsumer : BaseEventConsumer, IIntroActionsEvents
{
	[CompilerGenerated]
	private Action OnStartRaisingEvent; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnFinishRaisingEvent; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnPlaySoundEvent; //Field offset: 0x28

	public override event Action OnFinishRaisingEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnPlaySoundEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnStartRaisingEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public IntroActionsEventConsumer() { }

	[CompilerGenerated]
	public override void add_OnFinishRaisingEvent(Action value) { }

	[CompilerGenerated]
	public override void add_OnPlaySoundEvent(Action value) { }

	[CompilerGenerated]
	public override void add_OnStartRaisingEvent(Action value) { }

	private void OnFinishRaising(IAnimatorEventParameter param) { }

	public void OnPlaySound(IAnimatorEventParameter param) { }

	private void OnStartRaising(IAnimatorEventParameter param) { }

	[CompilerGenerated]
	public override void remove_OnFinishRaisingEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_OnPlaySoundEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_OnStartRaisingEvent(Action value) { }

}


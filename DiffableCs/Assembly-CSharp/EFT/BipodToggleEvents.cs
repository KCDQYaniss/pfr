namespace EFT;

public class BipodToggleEvents : BaseEventConsumer, IBipodToggleEvents
{
	[CompilerGenerated]
	private Action OnBipodToggleEvent; //Field offset: 0x18

	public override event Action OnBipodToggleEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public BipodToggleEvents() { }

	[CompilerGenerated]
	public override void add_OnBipodToggleEvent(Action value) { }

	private void OnBipodToggle(IAnimatorEventParameter parameter) { }

	[CompilerGenerated]
	public override void remove_OnBipodToggleEvent(Action value) { }

}


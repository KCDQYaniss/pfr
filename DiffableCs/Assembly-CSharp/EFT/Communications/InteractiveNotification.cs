namespace EFT.Communications;

public abstract class InteractiveNotification : Notification
{
	private Action _onClick; //Field offset: 0x30
	public BindableEvent OnRemove; //Field offset: 0x38

	protected InteractiveNotification(Action onClick) { }

	protected void Init(Action onClick) { }

	public override void OnClick() { }

}


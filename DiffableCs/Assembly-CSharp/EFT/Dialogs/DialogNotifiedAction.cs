namespace EFT.Dialogs;

public abstract class DialogNotifiedAction : DialogAction
{
	[CompilerGenerated]
	private bool <Notify>k__BackingField; //Field offset: 0x30

	[JsonProperty("needNotification")]
	public bool Notify
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected DialogNotifiedAction() { }

	[CompilerGenerated]
	public bool get_Notify() { }

	[CompilerGenerated]
	protected void set_Notify(bool value) { }

}


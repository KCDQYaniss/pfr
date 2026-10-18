namespace EFT;

public interface IPlayerVoipController
{

	public event Action AbuseNotification
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public BindableState HasInteraction
	{
		 get { } //Length: 0
	}

	public BindableState Status
	{
		 get { } //Length: 0
	}

	public BindableState TalkDetected
	{
		 get { } //Length: 0
	}

	public TimeSpan TimeToNextStatus
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_AbuseNotification(Action value) { }

	public void ForceMuteVoIP(bool enable) { }

	public BindableState get_HasInteraction() { }

	public BindableState get_Status() { }

	public BindableState get_TalkDetected() { }

	public TimeSpan get_TimeToNextStatus() { }

	[CompilerGenerated]
	public void remove_AbuseNotification(Action value) { }

	public void ReportAbuse() { }

	public EVoipControllerStatus StopTalk() { }

	public EVoipControllerStatus ToggleTalk() { }

}


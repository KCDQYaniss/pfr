namespace EFT.UI;

public interface IValidateDeviceIdScreenController
{

	public event Action OnValidateDeviceId
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnValidateDeviceId(Action value) { }

	public void CloseScreen() { }

	public void ErrorShow(string resultError) { }

	[CompilerGenerated]
	public void remove_OnValidateDeviceId(Action value) { }

	public void ShowScreen(EScreenState queued) { }

	public void ValidateDeviceId(string deviceId) { }

}


namespace Vuplex.WebView;

public interface IWithAudioStream
{

	public event Action AudioStreamPacketReceived
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool AudioStreamEnabled
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_AudioStreamPacketReceived(Action value) { }

	public bool get_AudioStreamEnabled() { }

	[CompilerGenerated]
	public void remove_AudioStreamPacketReceived(Action value) { }

	public void SetAudioStreamEnabled(bool enabled) { }

}


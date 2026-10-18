namespace UnityEngine.Timeline;

[CustomStyle("SignalEmitter")]
[ExcludeFromPreset]
public class SignalEmitter : Marker, INotification, INotificationOptionProvider
{
	[SerializeField]
	private bool m_Retroactive; //Field offset: 0x28
	[SerializeField]
	private bool m_EmitOnce; //Field offset: 0x29
	[SerializeField]
	private SignalAsset m_Asset; //Field offset: 0x30

	public SignalAsset asset
	{
		 get { } //Length: 76
		 set { } //Length: 82
	}

	public bool emitOnce
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool retroactive
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	private override PropertyName UnityEngine.Playables.INotification.id
	{
		private get { } //Length: 407
	}

	private override NotificationFlags UnityEngine.Timeline.INotificationOptionProvider.flags
	{
		private get { } //Length: 37
	}

	public SignalEmitter() { }

	public SignalAsset get_asset() { }

	public bool get_emitOnce() { }

	public bool get_retroactive() { }

	public void set_asset(SignalAsset value) { }

	public void set_emitOnce(bool value) { }

	public void set_retroactive(bool value) { }

	private override PropertyName UnityEngine.Playables.INotification.get_id() { }

	private override NotificationFlags UnityEngine.Timeline.INotificationOptionProvider.get_flags() { }

}


namespace Dissonance;

[HelpURL("https://placeholder-software.co.uk/dissonance/docs/Reference/Components/Voice-Broadcast-Trigger/")]
public class VoiceBroadcastTrigger : BaseCommsTrigger, IVoiceActivationListener
{
	[SerializeField]
	private bool _channelTypeExpanded; //Field offset: 0x50
	[SerializeField]
	private bool _metadataExpanded; //Field offset: 0x51
	[SerializeField]
	private bool _activationModeExpanded; //Field offset: 0x52
	[SerializeField]
	private bool _tokensExpanded; //Field offset: 0x53
	[SerializeField]
	private bool _ampExpanded; //Field offset: 0x54
	private Nullable _playerChannel; //Field offset: 0x58
	private Nullable _roomChannel; //Field offset: 0x80
	private bool _isVadSpeaking; //Field offset: 0xA8
	private Nullable _previousMode; //Field offset: 0xAC
	private IDissonancePlayer _self; //Field offset: 0xB8
	private Fader _activationFader; //Field offset: 0xC0
	[SerializeField]
	private VolumeFaderSettings _activationFaderSettings; //Field offset: 0xD8
	private Fader _triggerFader; //Field offset: 0xE0
	[SerializeField]
	private VolumeFaderSettings _triggerFaderSettings; //Field offset: 0xF8
	[SerializeField]
	private bool _broadcastPosition; //Field offset: 0x100
	[SerializeField]
	private CommTriggerTarget _channelType; //Field offset: 0x104
	[SerializeField]
	private string _inputName; //Field offset: 0x108
	[SerializeField]
	private CommActivationMode _mode; //Field offset: 0x110
	[SerializeField]
	private bool _muted; //Field offset: 0x114
	[SerializeField]
	private string _playerId; //Field offset: 0x118
	[SerializeField]
	private bool _useTrigger; //Field offset: 0x120
	[SerializeField]
	private string _roomName; //Field offset: 0x128
	[SerializeField]
	private ChannelPriority _priority; //Field offset: 0x130

	[NotNull]
	public VolumeFaderSettings ActivationFader
	{
		 get { } //Length: 8
	}

	public bool BroadcastPosition
	{
		 get { } //Length: 8
		 set { } //Length: 410
	}

	public virtual bool CanTrigger
	{
		 get { } //Length: 423
	}

	public CommTriggerTarget ChannelType
	{
		 get { } //Length: 7
		 set { } //Length: 22
	}

	[NotNull]
	public VolumeFaderSettings ColliderTriggerFader
	{
		 get { } //Length: 8
	}

	public float CurrentFaderVolume
	{
		 get { } //Length: 97
	}

	public string InputName
	{
		 get { } //Length: 8
		 set { } //Length: 82
	}

	public bool IsMuted
	{
		 get { } //Length: 8
		 set { } //Length: 105
	}

	public bool IsTransmitting
	{
		 get { } //Length: 80
	}

	public CommActivationMode Mode
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public string PlayerId
	{
		 get { } //Length: 8
		 set { } //Length: 191
	}

	public ChannelPriority Priority
	{
		 get { } //Length: 7
		 set { } //Length: 405
	}

	public string RoomName
	{
		 get { } //Length: 8
		 set { } //Length: 191
	}

	public virtual bool UseColliderTrigger
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public VoiceBroadcastTrigger() { }

	private void CloseChannel() { }

	protected virtual void ColliderTriggerChanged() { }

	private override void Dissonance.VAD.IVoiceActivationListener.VoiceActivationStart() { }

	private override void Dissonance.VAD.IVoiceActivationListener.VoiceActivationStop() { }

	public VolumeFaderSettings get_ActivationFader() { }

	public bool get_BroadcastPosition() { }

	public virtual bool get_CanTrigger() { }

	public CommTriggerTarget get_ChannelType() { }

	public VolumeFaderSettings get_ColliderTriggerFader() { }

	public float get_CurrentFaderVolume() { }

	public string get_InputName() { }

	public bool get_IsMuted() { }

	public bool get_IsTransmitting() { }

	public CommActivationMode get_Mode() { }

	public string get_PlayerId() { }

	public ChannelPriority get_Priority() { }

	public string get_RoomName() { }

	public virtual bool get_UseColliderTrigger() { }

	protected override bool IsUserActivated() { }

	protected virtual void OnDestroy() { }

	protected virtual void OnDisable() { }

	private void OpenChannel() { }

	public void set_BroadcastPosition(bool value) { }

	public void set_ChannelType(CommTriggerTarget value) { }

	public void set_InputName(string value) { }

	public void set_IsMuted(bool value) { }

	public void set_Mode(CommActivationMode value) { }

	public void set_PlayerId(string value) { }

	public void set_Priority(ChannelPriority value) { }

	public void set_RoomName(string value) { }

	public virtual void set_UseColliderTrigger(bool value) { }

	private void SetChannelVolume(float value) { }

	private bool ShouldActivate(bool intent) { }

	protected virtual void Start() { }

	private void SwitchMode() { }

	public void ToggleMute() { }

	protected virtual void Update() { }

}


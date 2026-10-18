namespace Dissonance;

[HelpURL("https://placeholder-software.co.uk/dissonance/docs/Reference/Components/Voice-Receipt-Trigger/")]
public class VoiceReceiptTrigger : BaseCommsTrigger
{
	private Nullable _membership; //Field offset: 0x50
	[SerializeField]
	private string _roomName; //Field offset: 0x68
	private bool _scriptDeactivated; //Field offset: 0x70
	[SerializeField]
	private bool _useTrigger; //Field offset: 0x71

	public virtual bool CanTrigger
	{
		 get { } //Length: 250
	}

	public string RoomName
	{
		 get { } //Length: 5
		 set { } //Length: 166
	}

	public virtual bool UseColliderTrigger
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public VoiceReceiptTrigger() { }

	public virtual bool get_CanTrigger() { }

	public string get_RoomName() { }

	public virtual bool get_UseColliderTrigger() { }

	private void JoinRoom() { }

	private void LeaveRoom() { }

	protected virtual void OnDisable() { }

	public void set_RoomName(string value) { }

	public virtual void set_UseColliderTrigger(bool value) { }

	[Obsolete("This is equivalent to enabling this component")]
	public void StartListening() { }

	[Obsolete("This is equivalent to disabling this component")]
	public void StopListening() { }

	protected virtual void Update() { }

}


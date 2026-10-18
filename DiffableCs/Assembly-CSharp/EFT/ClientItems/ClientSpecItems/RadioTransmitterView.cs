namespace EFT.ClientItems.ClientSpecItems;

public class RadioTransmitterView : MonoBehaviour
{
	[Header("Light signals")]
	[SerializeField]
	private Light _greenLight; //Field offset: 0x20
	[SerializeField]
	private Light _yellowLight; //Field offset: 0x28
	[SerializeField]
	private Light _redLight; //Field offset: 0x30
	[Header("Sound signals")]
	[SerializeField]
	private AudioClip _greenSoundSignal; //Field offset: 0x38
	[SerializeField]
	private AudioClip _yellowSoundSignal; //Field offset: 0x40
	[SerializeField]
	private AudioClip _redSoundSignal; //Field offset: 0x48
	private Player _player; //Field offset: 0x50
	private RTProcessor _processor; //Field offset: 0x58

	public RadioTransmitterView() { }

	public void Disable() { }

	public void Initialiaze(Player player) { }

	public void InitializeOnlyView() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnPlayerDeadOrUnspawn(Player player) { }

	private void SetActiveLightComponents(bool value) { }

	public void UpdateStatus(RadioTransmitterStatus transmitterStatus) { }

}


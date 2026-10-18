namespace EFT.ClientItems.ClientSpecItems.RT;

public class RTProcessor
{
	private RadioTransmitterStatus _status; //Field offset: 0x10
	private Transform _itemTransform; //Field offset: 0x18
	private RadioTransmitterHandler _radioTransmitterHandler; //Field offset: 0x20
	private readonly RTLightIndicator _lightIndicator; //Field offset: 0x28
	private readonly RTSoundIndicator _soundIndicator; //Field offset: 0x30

	public RTProcessor(RadioTransmitterView rtView, Transform itemTransform, RadioTransmitterHandler radioTransmitterHandler, Light greenLight, Light yellowLight, Light redLight, AudioClip greenSoundSignal, AudioClip yellowSoundSignal, AudioClip redSoundSignal) { }

	public void ClearData() { }

	public void ForceSetStatus(RadioTransmitterStatus status) { }

	public void OnDestroy() { }

	public void OnDisable() { }

	public void OnEnable() { }

	private void SetCurrentState() { }

	public void SetHandler(RadioTransmitterHandler handler) { }

	private void UpdateStatus(RadioTransmitterStatus newStatus) { }

}


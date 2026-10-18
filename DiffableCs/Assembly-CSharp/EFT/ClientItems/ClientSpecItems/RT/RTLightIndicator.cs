namespace EFT.ClientItems.ClientSpecItems.RT;

public class RTLightIndicator
{
	private Light _greenLight; //Field offset: 0x10
	private Light _yellowLight; //Field offset: 0x18
	private Light _redLight; //Field offset: 0x20
	private RadioTransmitterStatus _cachedStatus; //Field offset: 0x28

	public RTLightIndicator(Light greenLight, Light yellowLight, Light redLight) { }

	public void SetLightSignal(RadioTransmitterStatus status) { }

	public void StopProcessingLightSignal() { }

}


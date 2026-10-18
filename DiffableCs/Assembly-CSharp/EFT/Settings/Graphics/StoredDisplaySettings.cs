namespace EFT.Settings.Graphics;

public sealed class StoredDisplaySettings
{
	public byte Index; //Field offset: 0x10
	public EftResolution FullScreenResolution; //Field offset: 0x14
	public AspectRatio FullScreenAspectRatio; //Field offset: 0x1C
	public EftResolution WindowResolution; //Field offset: 0x24
	public AspectRatio WindowAspectRatio; //Field offset: 0x2C

	public StoredDisplaySettings() { }

	public void ApplyTo(ref EftDisplaySettings settings) { }

	public static StoredDisplaySettings Create(in EftDisplaySettings settings) { }

	public void Update(in EftDisplaySettings settings) { }

}


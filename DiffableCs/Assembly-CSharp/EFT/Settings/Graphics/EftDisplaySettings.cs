namespace EFT.Settings.Graphics;

public struct EftDisplaySettings : IEquatable
{
	public byte Display; //Field offset: 0x0
	[JsonConverter(typeof(FullScreenModeJsonConverter))]
	public FullScreenMode FullScreenMode; //Field offset: 0x4
	public EftResolution Resolution; //Field offset: 0x8
	public AspectRatio AspectRatio; //Field offset: 0x10

	public override bool Equals(EftDisplaySettings other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}


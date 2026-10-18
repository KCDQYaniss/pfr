namespace EFT.Rendering.Clouds;

public struct CloudProxy : IRelay
{
	internal struct CloudMapProxy
	{
		public float OpacityR; //Field offset: 0x0
		public float OpacityG; //Field offset: 0x4
		public float OpacityB; //Field offset: 0x8
		public float OpacityA; //Field offset: 0xC
		public float Altitude; //Field offset: 0x10
		public float Rotation; //Field offset: 0x14
		public Color Tint; //Field offset: 0x18
		public float Exposure; //Field offset: 0x28
		public float ScrollOrientation; //Field offset: 0x2C
		public float ScrollSpeed; //Field offset: 0x30
		public bool Lighting; //Field offset: 0x34
		public int Steps; //Field offset: 0x38
		public float Thickness; //Field offset: 0x3C
		public float AmbientProbeDimmer; //Field offset: 0x40
		public bool CastShadows; //Field offset: 0x44
		public float ScrollFactor; //Field offset: 0x48

	}

	public float Opacity; //Field offset: 0x0
	public float ShadowMultiplier; //Field offset: 0x4
	public Color ShadowTint; //Field offset: 0x8
	public float ShadowSize; //Field offset: 0x18
	public Vector4 PlanetCenterRadius; //Field offset: 0x1C
	public CloudMapProxy LayerA; //Field offset: 0x2C
	public CloudMapProxy LayerB; //Field offset: 0x78

	[CompilerGenerated]
	internal static void <Init>g__InitLayerProperties|8_0(ref CloudMapProxy destination, CloudMap source) { }

	[CompilerGenerated]
	internal static void <Relay>g__RelayLayerProperties|9_0(ref CloudMap destination, CloudMapProxy source) { }

	public override void Init(CloudLayer original) { }

	public override void Relay(CloudLayer original) { }

}


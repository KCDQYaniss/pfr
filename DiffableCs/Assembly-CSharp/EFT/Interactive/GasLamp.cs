namespace EFT.Interactive;

public class GasLamp : Turnable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__10_0; //Field offset: 0x8
		public static Func <>9__10_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal LightDescriptor <Awake>b__10_0(Light x) { }

		internal MultiFlareDescriptor <Awake>b__10_1(FlareLight x) { }

	}

	internal enum FlickerSounds
	{
		Flicker1 = 0,
		Flicker2 = 1,
		Flicker3 = 2,
		Flicker4 = 3,
	}

	private struct LightDescriptor
	{
		public Light Light; //Field offset: 0x0
		public float OriginalIntensity; //Field offset: 0x8

	}

	private struct MultiFlareDescriptor
	{
		public FlareLight Light; //Field offset: 0x0
		public float OriginalAlpha; //Field offset: 0x8

	}

	private static readonly int _on; //Field offset: 0x0
	[SerializeField]
	private AudioSource _audioSource; //Field offset: 0x38
	[SerializeField]
	private float _intensity; //Field offset: 0x40
	private float _previousIntensity; //Field offset: 0x44
	private LightDescriptor[] _lights; //Field offset: 0x48
	private MultiFlareDescriptor[] _flares; //Field offset: 0x50

	private static GasLamp() { }

	public GasLamp() { }

	private void Awake() { }

	private void OnValidate() { }

	public void PlaySound(AudioClip clip) { }

	public virtual void Switch(EState switchTo) { }

	private void Update() { }

}


namespace EFT.Dialogs;

public class AudioVisualizer
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__Abs; //Field offset: 0x0

	}

	private const int SAMPLE_SIZE = 256; //Field offset: 0x0
	private readonly AudioSource _audioSource; //Field offset: 0x10
	private readonly Image _fillImage; //Field offset: 0x18
	private readonly float[] _samples; //Field offset: 0x20

	public AudioVisualizer(AudioSource audioSource, Image fillImage) { }

	public void Tick() { }

	private void UpdateFillImage(float amplitude) { }

}


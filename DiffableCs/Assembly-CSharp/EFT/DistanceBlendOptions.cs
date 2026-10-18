namespace EFT;

public class DistanceBlendOptions : ScriptableObject
{
	public EAudioFadeType FadeType; //Field offset: 0x18
	public float[] Values; //Field offset: 0x20

	public DistanceBlendOptions() { }

	public float Evaluate(float t) { }

}


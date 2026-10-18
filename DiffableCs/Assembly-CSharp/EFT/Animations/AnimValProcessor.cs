namespace EFT.Animations;

public class AnimValProcessor
{
	public AnimVal Values; //Field offset: 0x10
	private float _intensity; //Field offset: 0x18
	public float _frequency; //Field offset: 0x1C
	public float _time; //Field offset: 0x20
	public ValProcessor[] Processors; //Field offset: 0x28

	public AnimValProcessor(AnimVal values) { }

	public void Initialize(Spring rootRotation, Spring handsPosition, Spring handsRotation, float parentIntensity = 1, float parentFrequency = 1, bool isHeadbobbing = false) { }

	public void Process(float deltaTime) { }

	public void ProcessAtTime(float time, float intensity = 1) { }

	public void ProcessRaw(float deltaTime, float intensity) { }

	internal void ResetTime() { }

	public void SetupParentValues(float parentIntensity, float parentFrequency) { }

}


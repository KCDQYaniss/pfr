namespace CW2.Animations;

public class SmoothRandom
{
	[FormerlySerializedAs("Amlitude")]
	[Range(0, 5)]
	public float Amplitude; //Field offset: 0x10
	[MinMaxVec2(0, 1, -1)]
	public Vector2 MinMaxDelay; //Field offset: 0x14
	[Range(0, 2)]
	public float Hardness; //Field offset: 0x1C
	private float _countDown; //Field offset: 0x20
	private float _currentVal; //Field offset: 0x24
	private float _increase; //Field offset: 0x28

	public SmoothRandom() { }

	public float GetValue(float deltaTime) { }

}


//Type is in global namespace

public class BetterSourceHRTFCalculator : IHRTFCalculator
{
	private const float SQR_TOO_CLOSE_FOR_BINAURAL = 2.25; //Field offset: 0x0
	private readonly AudioGroupPreset _preset; //Field offset: 0x10
	private readonly SpatializerSettings _spatializationSettings; //Field offset: 0x18
	private readonly float _sqrEnableBinauralDistance; //Field offset: 0x20

	public BetterSourceHRTFCalculator(AudioGroupPreset preset) { }

	public override float CalculateHRTF(Vector3 sourcePosition) { }

}


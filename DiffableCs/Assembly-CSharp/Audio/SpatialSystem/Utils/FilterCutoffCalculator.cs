namespace Audio.SpatialSystem.Utils;

public class FilterCutoffCalculator
{
	private const float MIN_FILTER_FREQUENCY = 20; //Field offset: 0x0
	private const float MAX_FILTER_FREQUENCY = 20000; //Field offset: 0x0
	private readonly FloorHeightCalculator _floorHeightCalculator; //Field offset: 0x10
	private readonly AbstractLogger _logger; //Field offset: 0x18

	public FilterCutoffCalculator(FloorHeightCalculator floorHeightCalculator, AbstractLogger logger) { }

	public void Compute(AudioOcclusionEQPreset preset, float occlusion, DirectionalWeights influencedWeights, float heightDistance, bool isPropagationActive, float floorHeightSetting, float isolationFactor, bool isInDiffEvn, out float lowPassFreq, out float highPassFreq) { }

}


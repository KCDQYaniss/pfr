namespace Audio.SpatialSystem.Utils;

public class DirectionalWeightCalculator
{
	private const float WEIGHTS_EPSILON = 1E-05; //Field offset: 0x0
	private readonly Transform _listenerTransform; //Field offset: 0x10

	public DirectionalWeightCalculator(Transform listenerTransform) { }

	public DirectionalWeights Calculate(Vector3 soundPos) { }

	public DirectionalWeights Influence(DirectionalWeights w, float rotationCoefficient, float distanceCoefficient, float distancePercentage) { }

}


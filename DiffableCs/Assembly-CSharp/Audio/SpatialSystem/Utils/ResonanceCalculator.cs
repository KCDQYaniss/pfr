namespace Audio.SpatialSystem.Utils;

public class ResonanceCalculator
{
	private const float MinThreshold = 0.1; //Field offset: 0x0

	public ResonanceCalculator() { }

	public void Compute(Vector3 listenerPos, Vector3 sourcePos, AudioGroupOcclusionSettings settings, bool isPropagationActive, out float lowPassResonance, out float highPassResonance) { }

}


namespace Audio.SpatialSystem.Utils;

internal class StairsOcclusionTransition
{
	private readonly float _smoothingFactor; //Field offset: 0x10
	private readonly float _threshold; //Field offset: 0x14
	private float _smoothedEffect; //Field offset: 0x18

	private bool ShouldApply
	{
		private get { } //Length: 13
	}

	public float SmoothedEffect
	{
		 get { } //Length: 6
	}

	public StairsOcclusionTransition(float smoothingFactor, float threshold = 0.001) { }

	private bool get_ShouldApply() { }

	public float get_SmoothedEffect() { }

	public bool TryUpdate(SpatialAudioSystem audioSystem, AudioSourceContainer container, Transform listenerTransform) { }

	public void Update(bool isInStairs, float rawHeight, float deltaTime) { }

}


namespace Audio.SpatialSystem;

public interface IAudioOccluded
{

	public float ObstructionEffect
	{
		 get { } //Length: 0
	}

	public float OcclusionEffect
	{
		 get { } //Length: 0
	}

	public float PropagationEffect
	{
		 get { } //Length: 0
	}

	public float get_ObstructionEffect() { }

	public float get_OcclusionEffect() { }

	public float get_PropagationEffect() { }

}


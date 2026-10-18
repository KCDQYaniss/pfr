namespace EFT.Hideout;

public class RailCameraMoveSettings
{
	[SerializeField]
	private float _delta; //Field offset: 0x10
	[SerializeField]
	private float _defaultNormalizedTime; //Field offset: 0x14
	[SerializeField]
	private Animation _animation; //Field offset: 0x18
	[SerializeField]
	private float _animationSpeed; //Field offset: 0x20

	public Animation Animation
	{
		 get { } //Length: 5
	}

	public float AnimationSpeed
	{
		 get { } //Length: 6
	}

	public float DefaultNormalizedTime
	{
		 get { } //Length: 6
	}

	public float Delta
	{
		 get { } //Length: 6
	}

	public RailCameraMoveSettings() { }

	public Animation get_Animation() { }

	public float get_AnimationSpeed() { }

	public float get_DefaultNormalizedTime() { }

	public float get_Delta() { }

}


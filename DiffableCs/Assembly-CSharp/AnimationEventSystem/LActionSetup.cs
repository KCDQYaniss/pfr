namespace AnimationEventSystem;

public class LActionSetup
{
	public float StartThreshold; //Field offset: 0x10
	public AnimationCurve LayerWeight; //Field offset: 0x18
	[SerializeField]
	private int _stateHash; //Field offset: 0x20

	public int StateHash
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public LActionSetup(AnimationCurve animationCurve, float startThreshold) { }

	public int get_StateHash() { }

	public void set_StateHash(int value) { }

}


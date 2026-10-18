namespace RootMotion.FinalIK;

public abstract class Poser : MonoBehaviour
{
	public Transform poseRoot; //Field offset: 0x20
	[Range(0, 1)]
	public float weight; //Field offset: 0x28
	[Range(0, 1)]
	public float localRotationWeight; //Field offset: 0x2C
	[Range(0, 1)]
	public float localPositionWeight; //Field offset: 0x30
	public bool fixTransforms; //Field offset: 0x34

	protected Poser() { }

	public abstract void AutoMapping() { }

	public abstract void FixTransforms() { }

	public abstract void StoreDefaultState() { }

}


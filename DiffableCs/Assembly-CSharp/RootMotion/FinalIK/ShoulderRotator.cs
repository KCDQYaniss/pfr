namespace RootMotion.FinalIK;

public class ShoulderRotator : MonoBehaviour
{
	[Tooltip("Weight of shoulder rotation")]
	public float weight; //Field offset: 0x20
	[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
	public float offset; //Field offset: 0x24
	private FullBodyBipedIK ik; //Field offset: 0x28
	private bool skip; //Field offset: 0x30

	public ShoulderRotator() { }

	private BoneMap GetParentBoneMap(FullBodyBipedChain chain) { }

	private void OnDestroy() { }

	private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset) { }

	private void RotateShoulders() { }

	private void Start() { }

}


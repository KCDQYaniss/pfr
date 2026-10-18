namespace RootMotion.FinalIK;

public class FBBIKArmBending : MonoBehaviour
{
	public FullBodyBipedIK ik; //Field offset: 0x20
	public Vector3 bendDirectionOffsetLeft; //Field offset: 0x28
	public Vector3 bendDirectionOffsetRight; //Field offset: 0x34
	public Vector3 characterSpaceBendOffsetLeft; //Field offset: 0x40
	public Vector3 characterSpaceBendOffsetRight; //Field offset: 0x4C
	private Quaternion leftHandTargetRotation; //Field offset: 0x58
	private Quaternion rightHandTargetRotation; //Field offset: 0x68
	private bool initiated; //Field offset: 0x78

	public FBBIKArmBending() { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	private void OnPostFBBIK() { }

}


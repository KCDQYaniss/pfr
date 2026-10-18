namespace RootMotion.FinalIK;

[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
public class RotationLimitHinge : RotationLimit
{
	public bool useLimits; //Field offset: 0x40
	public float min; //Field offset: 0x44
	public float max; //Field offset: 0x48
	[HideInInspector]
	public float zeroAxisDisplayOffset; //Field offset: 0x4C
	private Quaternion lastRotation; //Field offset: 0x50
	private float lastAngle; //Field offset: 0x60

	public RotationLimitHinge() { }

	[ContextMenu("Asset Store Thread")]
	private void ASThread() { }

	private Quaternion LimitHinge(Quaternion rotation) { }

	protected virtual Quaternion LimitRotation(Quaternion rotation) { }

	[ContextMenu("Scrpt Reference")]
	private void OpenScriptReference() { }

	[ContextMenu("User Manual")]
	private void OpenUserManual() { }

	[ContextMenu("Support Group")]
	private void SupportGroup() { }

}


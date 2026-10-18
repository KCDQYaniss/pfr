namespace RootMotion.FinalIK;

[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
public class RotationLimitAngle : RotationLimit
{
	[Range(0, 180)]
	public float limit; //Field offset: 0x40
	[Range(0, 180)]
	public float twistLimit; //Field offset: 0x44

	public RotationLimitAngle() { }

	[ContextMenu("Asset Store Thread")]
	private void ASThread() { }

	protected virtual Quaternion LimitRotation(Quaternion rotation) { }

	private Quaternion LimitSwing(Quaternion rotation) { }

	[ContextMenu("Scrpt Reference")]
	private void OpenScriptReference() { }

	[ContextMenu("User Manual")]
	private void OpenUserManual() { }

	[ContextMenu("Support Group")]
	private void SupportGroup() { }

}


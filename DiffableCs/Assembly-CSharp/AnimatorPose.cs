//Type is in global namespace

[CreateAssetMenu]
public class AnimatorPose : ScriptableObject
{
	public Vector3 Position; //Field offset: 0x18
	public Vector3 Rotation; //Field offset: 0x24
	public Vector3 CameraRotation; //Field offset: 0x30
	public Vector3 CameraPosition; //Field offset: 0x3C
	public AnimationCurve Blend; //Field offset: 0x48

	public AnimatorPose() { }

}


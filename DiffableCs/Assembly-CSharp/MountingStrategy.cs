//Type is in global namespace

public class MountingStrategy : IProceduralAnimationStrategy
{
	private struct StoredWorldPosition
	{
		public Transform StoredTransform; //Field offset: 0x0
		public Vector3 Position; //Field offset: 0x8
		public Quaternion Rotation; //Field offset: 0x14

	}

	private readonly List _storedWorldPositions; //Field offset: 0x10

	public MountingStrategy() { }

	public override void ApplyCameraTransformations(ProceduralWeaponAnimation pwa, float dt) { }

	public override void ApplyFovAdjustments(ProceduralWeaponAnimation pwa, Player player) { }

	public override void ApplyFovAdjustments(ProceduralWeaponAnimation pwa, ObservedPlayerView player) { }

	public override void ApplyTransformations(ProceduralWeaponAnimation pwa, float dt, bool overrideWeaponTransformParameters) { }

	public override void LateTransformations(ProceduralWeaponAnimation pwa, float dt) { }

	public override void OpticCalibration(ProceduralWeaponAnimation proceduralWeaponAnimation, bool calibrate) { }

	public override void ProcessEffectors(ProceduralWeaponAnimation pwa, float deltaTime, int nFixedFrames = 1) { }

	public override void ResetFovAdjustments(ProceduralWeaponAnimation pwa, ObservedPlayerView player) { }

	public override void ResetFovAdjustments(ProceduralWeaponAnimation pwa, Player player) { }

	public override float UpdatePossibleTilt(ProceduralWeaponAnimation proceduralWeaponAnimation, float smoothedCharacterMovementSpeed, float smoothedPoseLevel) { }

}


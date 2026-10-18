//Type is in global namespace

public class StationaryStrategy : IProceduralAnimationStrategy
{

	public StationaryStrategy() { }

	public override void ApplyCameraTransformations(ProceduralWeaponAnimation pwa, float dt) { }

	public override void ApplyFovAdjustments(ProceduralWeaponAnimation proceduralWeaponAnimation, Player player) { }

	public override void ApplyFovAdjustments(ProceduralWeaponAnimation proceduralWeaponAnimation, ObservedPlayerView player) { }

	public override void ApplyTransformations(ProceduralWeaponAnimation pwa, float dt, bool overrideWeaponTransformParameters) { }

	public override void LateTransformations(ProceduralWeaponAnimation pwa, float dt) { }

	public override void OpticCalibration(ProceduralWeaponAnimation proceduralWeaponAnimation, bool calibrate) { }

	public override void ProcessEffectors(ProceduralWeaponAnimation pwa, float deltaTime, int nFixedFrames = 1) { }

	public override void ResetFovAdjustments(ProceduralWeaponAnimation proceduralWeaponAnimation, Player player) { }

	public override void ResetFovAdjustments(ProceduralWeaponAnimation proceduralWeaponAnimation, ObservedPlayerView player) { }

	public override float UpdatePossibleTilt(ProceduralWeaponAnimation proceduralWeaponAnimation, float smoothedCharacterMovementSpeed, float smoothedPoseLevel) { }

}


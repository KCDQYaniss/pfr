//Type is in global namespace

public interface IProceduralAnimationStrategy
{

	public void ApplyCameraTransformations(ProceduralWeaponAnimation pwa, float dt) { }

	public void ApplyFovAdjustments(ProceduralWeaponAnimation proceduralWeaponAnimation, Player player) { }

	public void ApplyFovAdjustments(ProceduralWeaponAnimation proceduralWeaponAnimation, ObservedPlayerView player) { }

	public void ApplyTransformations(ProceduralWeaponAnimation pwa, float dt, bool overrideWeaponTransformParameters) { }

	public void LateTransformations(ProceduralWeaponAnimation pwa, float dt) { }

	public void OpticCalibration(ProceduralWeaponAnimation proceduralWeaponAnimation, bool calibrate) { }

	public void ProcessEffectors(ProceduralWeaponAnimation pwa, float deltaTime, int nFixedFrames = 1) { }

	public void ResetFovAdjustments(ProceduralWeaponAnimation proceduralWeaponAnimation, Player player) { }

	public void ResetFovAdjustments(ProceduralWeaponAnimation proceduralWeaponAnimation, ObservedPlayerView player) { }

	public float UpdatePossibleTilt(ProceduralWeaponAnimation proceduralWeaponAnimation, float smoothedCharacterMovementSpeed, float smoothedPoseLevel) { }

}


namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerBatchTorsoReaction
{
	private static class Hit
	{
		public const float DECAY_SPEED = 6; //Field offset: 0x0
		public const float DISPLAY_SMOOTH_TIME = 0.06; //Field offset: 0x0
		public const float FORCE_TO_DEGREES = 5.5; //Field offset: 0x0
		public const float MAX_CHANNEL_EULER = 6.5; //Field offset: 0x0
		public const float PELVIS_FORCE_TO_METERS = 0.03; //Field offset: 0x0
		public const float PELVIS_DECAY_SPEED = 6; //Field offset: 0x0
		public const float PELVIS_DISPLAY_SMOOTH_TIME = 0.06; //Field offset: 0x0

		public static float GetBodyPartMultiplier(EBodyPart bodyPart) { }

	}

	private static class Recoil
	{
		public const float DECAY_SPEED = 7; //Field offset: 0x0
		public const float DISPLAY_SMOOTH_TIME = 0.045; //Field offset: 0x0
		public const float ATTACK_DISPLAY_BLEND = 0.55; //Field offset: 0x0
		public const float FORCE_TO_DEGREES = 1.78125; //Field offset: 0x0
		public const float MAX_CHANNEL_EULER = 2.625; //Field offset: 0x0
		public const float WEAPON_FORCE_BACK_SCALE = 0.0038; //Field offset: 0x0
		public const float WEAPON_FORCE_MIN = 0.09; //Field offset: 0x0
		public const float WEAPON_FORCE_MAX = 1.05; //Field offset: 0x0
		public const float PELVIS_FORCE_TO_METERS = 0.025; //Field offset: 0x0
		public const float PELVIS_DECAY_SPEED = 4.5; //Field offset: 0x0
		public const float PELVIS_DISPLAY_SMOOTH_TIME = 0.045; //Field offset: 0x0
		public const float PELVIS_RETURN_HOLD_SECONDS = 0.045; //Field offset: 0x0

	}

	internal static class Shared
	{
		public const float FORCE_DIVIDER = 2.4; //Field offset: 0x0
		public const float LATERAL_TO_DEGREES = 0.5; //Field offset: 0x0
		public const float MAX_COMBINED_SPINE_EULER = 6; //Field offset: 0x0
		public const float SETTLE_EPSILON = 0.02; //Field offset: 0x0
		public const float SPINE1_SHARE = 0.5; //Field offset: 0x0
		public const float SPINE1_ACTIVATION_EPSILON = 0.01; //Field offset: 0x0
		public const float HIT_WEAPON_COUNTER_SCALE = 2; //Field offset: 0x0
		public const float RECOIL_WEAPON_COUNTER_SCALE = 1.15; //Field offset: 0x0
		public const float WEAPON_POSITIONAL_RECOIL_SCALE = 0.4; //Field offset: 0x0
		public const float WEAPON_POSITIONAL_RECOIL_MAX = 0.028; //Field offset: 0x0
		public const float MAX_PELVIS_OFFSET_METERS = 0.035; //Field offset: 0x0
		public const float MAX_PELVIS_DOWN_METERS = 0.0125; //Field offset: 0x0
		public const float PELVIS_LATERAL_SCALE = 0.35; //Field offset: 0x0
		public const float PELVIS_SETTLE_EPSILON = 0.0004; //Field offset: 0x0
		public const float PELVIS_METERS_TO_PITCH_DEGREES = 50; //Field offset: 0x0

	}

	private struct TorsoReactionChannel
	{
		public float3 Target; //Field offset: 0x0
		public float3 Display; //Field offset: 0xC
		public float3 DisplayVelocity; //Field offset: 0x18

		public bool IsActive
		{
			 get { } //Length: 122
		}

		public void ApplyImpulse(in float3 delta, float maxMagnitude, bool snapDisplay = true, float attackDisplayBlend = 0) { }

		public bool get_IsActive() { }

		public bool IsAbove(float epsilon) { }

		public void Reset() { }

		public void Tick(float deltaTime, float decaySpeed, float smoothTime, float maxMagnitude) { }

	}

	private TorsoReactionChannel _hit; //Field offset: 0x10
	private TorsoReactionChannel _recoil; //Field offset: 0x34
	private TorsoReactionChannel _hitPelvis; //Field offset: 0x58
	private TorsoReactionChannel _recoilPelvis; //Field offset: 0x7C
	private float _recoilPelvisReturnHold; //Field offset: 0xA0
	private bool _pendingSpineCleanup; //Field offset: 0xA4
	private int _impulseFrame; //Field offset: 0xA8
	private quaternion _spine3AnimBaseline; //Field offset: 0xAC
	private quaternion _spine1AnimBaseline; //Field offset: 0xBC

	private bool HasActivePelvisReaction
	{
		private get { } //Length: 48
	}

	private bool HasActiveReaction
	{
		private get { } //Length: 78
	}

	private bool HasActiveSpineReaction
	{
		private get { } //Length: 48
	}

	public bool NeedsPelvisReactionApply
	{
		 get { } //Length: 48
	}

	public bool NeedsReactionApply
	{
		 get { } //Length: 86
	}

	public bool NeedsSpineReactionApply
	{
		 get { } //Length: 60
	}

	public ObservedPlayerBatchTorsoReaction() { }

	public void ApplyHit(Vector3 worldForce, EBodyPart bodyPart, Transform bodyTransform) { }

	private void ApplyRecoilPelvisImpulse(in float3 xzDelta) { }

	public void ApplyShot(IWeapon weapon, Vector3 shotDirection, Transform bodyTransform) { }

	public void ConfirmSpineApplied(in float3 appliedEuler) { }

	private static float3 FinalizeRecoilPelvisOffset(in float3 offset) { }

	private bool get_HasActivePelvisReaction() { }

	private bool get_HasActiveReaction() { }

	private bool get_HasActiveSpineReaction() { }

	public bool get_NeedsPelvisReactionApply() { }

	public bool get_NeedsReactionApply() { }

	public bool get_NeedsSpineReactionApply() { }

	private static float3 GetChannelBendForWeaponCounter(in float3 spineDisplay, in float3 pelvisDisplay) { }

	public float GetCombinedDisplayPitchDegrees() { }

	private float3 GetDisplayEuler() { }

	private float3 GetPelvisDisplayOffset() { }

	private static float3 GetSpine1Euler(in float3 euler) { }

	private static float3 LocalForceToEulerDelta(in float3 localForce, float forceToDegrees) { }

	private static float3 LocalForceToPelvisDelta(in float3 localForce, float forceToMeters) { }

	private static float3 LocalForceToRecoilSpineEulerDelta(in float3 localForce, float forceToDegrees) { }

	public void Reset() { }

	private static float3 SmoothDamp(float3 current, float3 target, ref float3 velocity, float smoothTime, float deltaTime) { }

	private void SnapIfSettled() { }

	public void TickDecay(float deltaTime) { }

	private void TickRecoilPelvis(float deltaTime) { }

	public bool TryBuildFrameInput(PlayerBones bones, Transform leftThigh, Transform leftCalf, Transform leftFoot, Transform rightThigh, Transform rightCalf, Transform rightFoot, out ObservedPlayerBodyReactionFrameInput frameInput) { }

	public bool TryGetWeaponCounterRootRotation(out Quaternion counterRotation) { }

}


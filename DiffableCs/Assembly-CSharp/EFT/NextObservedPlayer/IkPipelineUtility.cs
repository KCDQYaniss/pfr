namespace EFT.NextObservedPlayer;

internal static class IkPipelineUtility
{

	public static void ApplyIkTarget(IKSolverLimb solver, float3 position, quaternion rotation) { }

	public static float3 ClampMagnitude(float3 vector, float maxMagnitude) { }

	public static void DisposeIfCreated(ref NativeArray array) { }

	public static void DisposeIfCreated(ref TransformAccessArray transforms) { }

	public static bool EnsureSolverInitiated(IKSolverLimb solver, Transform root) { }

	public static void PrepareTransformAccessArray(ref TransformAccessArray transforms, int count) { }

	public static float3 ToFloat3(Vector3 value) { }

	public static quaternion ToQuaternion(Quaternion value) { }

	public static Quaternion ToUnityQuaternion(quaternion value) { }

	public static Vector3 ToVector3(float3 value) { }

	public static bool TryGetLimbBoneTransforms(IKSolverLimb solver, out Transform bone1, out Transform bone2, out Transform bone3) { }

}


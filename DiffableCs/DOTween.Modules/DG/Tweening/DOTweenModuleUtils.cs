namespace DG.Tweening;

public static class DOTweenModuleUtils
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__SetOrientationOnPath; //Field offset: 0x0

	}

	internal static class Physics
	{

		[Preserve]
		public static TweenerCore CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode) { }

		[Preserve]
		public static bool HasRigidbody(Component target) { }

		public static bool HasRigidbody2D(Component target) { }

		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans) { }

	}

	private static bool _initialized; //Field offset: 0x0

	[Preserve]
	public static void Init() { }

	[Preserve]
	private static void Preserver() { }

}


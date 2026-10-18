namespace CommonAssets.Scripts.AI.CustomBehaviourNodes.Debug;

public class DebugUnderbarrelLauncherNode : BaseNode
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_0; //Field offset: 0x8
		public static Func <>9__5_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__5_0(DebugMarker marker) { }

		internal bool <.ctor>b__5_1(DebugMarker marker) { }

	}

	private float _updatePointTimer; //Field offset: 0x18
	private readonly DebugMarker[] _debugMarkers; //Field offset: 0x20
	private readonly Transform _shootPoint; //Field offset: 0x28
	private readonly Transform _aimTarget; //Field offset: 0x30
	private readonly AimingDebugShoot _aimingDebug; //Field offset: 0x38

	public DebugUnderbarrelLauncherNode(BotOwner bot) { }

	public virtual void UpdateNodeByBrain(AimingResultParams data) { }

}


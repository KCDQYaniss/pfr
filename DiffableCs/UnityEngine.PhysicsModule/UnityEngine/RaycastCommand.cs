namespace UnityEngine;

[NativeHeader("Modules/Physics/BatchCommands/RaycastCommand.h")]
[NativeHeader("Runtime/Jobs/ScriptBindings/JobsBindingsTypes.h")]
public struct RaycastCommand
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector3 <from>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector3 <direction>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PhysicsScene <physicsScene>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <distance>k__BackingField; //Field offset: 0x1C
	public QueryParameters queryParameters; //Field offset: 0x20

	public Vector3 direction
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public float distance
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public Vector3 from
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 15
	}

	[Obsolete("Layer Mask is now a part of QueryParameters struct", False)]
	public int layerMask
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	[Obsolete("maxHits property was moved to be a part of RaycastCommand.ScheduleBatch.", False)]
	public int maxHits
	{
		 set { } //Length: 3
	}

	public PhysicsScene physicsScene
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public RaycastCommand(Vector3 from, Vector3 direction, QueryParameters queryParameters, float distance = 3.4028235E+38) { }

	[Obsolete("This struct signature is no longer supported. Use struct with a QueryParameters instead", False)]
	public RaycastCommand(Vector3 from, Vector3 direction, float distance = 3.4028235E+38, int layerMask = -5, int maxHits = 1) { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector3 get_direction() { }

	[CompilerGenerated]
	[IsReadOnly]
	public float get_distance() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector3 get_from() { }

	public int get_layerMask() { }

	public static JobHandle ScheduleBatch(NativeArray commands, NativeArray results, int minCommandsPerJob, int maxHits, JobHandle dependsOn = null) { }

	public static JobHandle ScheduleBatch(NativeArray commands, NativeArray results, int minCommandsPerJob, JobHandle dependsOn = null) { }

	[FreeFunction("ScheduleRaycastCommandBatch", ThrowsException = True)]
	private static JobHandle ScheduleRaycastBatch(ref JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits) { }

	private static void ScheduleRaycastBatch_Injected(ref JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out JobHandle ret) { }

	[CompilerGenerated]
	public void set_direction(Vector3 value) { }

	[CompilerGenerated]
	public void set_distance(float value) { }

	[CompilerGenerated]
	public void set_from(Vector3 value) { }

	public void set_layerMask(int value) { }

	public void set_maxHits(int value) { }

	[CompilerGenerated]
	public void set_physicsScene(PhysicsScene value) { }

}


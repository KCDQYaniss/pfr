namespace UnityEngine;

[NativeHeader("Modules/Physics/BatchCommands/SpherecastCommand.h")]
[NativeHeader("Runtime/Jobs/ScriptBindings/JobsBindingsTypes.h")]
public struct SpherecastCommand
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector3 <origin>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <radius>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector3 <direction>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <distance>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PhysicsScene <physicsScene>k__BackingField; //Field offset: 0x20
	public QueryParameters queryParameters; //Field offset: 0x24

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

	[Obsolete("Layer Mask is now a part of QueryParameters struct", False)]
	public int layerMask
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public Vector3 origin
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public PhysicsScene physicsScene
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public float radius
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public SpherecastCommand(Vector3 origin, float radius, Vector3 direction, QueryParameters queryParameters, float distance = 3.4028235E+38) { }

	[Obsolete("This struct signature is no longer supported. Use struct with a QueryParameters instead", False)]
	public SpherecastCommand(Vector3 origin, float radius, Vector3 direction, float distance = 3.4028235E+38, int layerMask = -5) { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector3 get_direction() { }

	[CompilerGenerated]
	[IsReadOnly]
	public float get_distance() { }

	public int get_layerMask() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector3 get_origin() { }

	[CompilerGenerated]
	[IsReadOnly]
	public float get_radius() { }

	public static JobHandle ScheduleBatch(NativeArray commands, NativeArray results, int minCommandsPerJob, JobHandle dependsOn = null) { }

	public static JobHandle ScheduleBatch(NativeArray commands, NativeArray results, int minCommandsPerJob, int maxHits, JobHandle dependsOn = null) { }

	[FreeFunction("ScheduleSpherecastCommandBatch", ThrowsException = True)]
	private static JobHandle ScheduleSpherecastBatch(ref JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits) { }

	private static void ScheduleSpherecastBatch_Injected(ref JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out JobHandle ret) { }

	[CompilerGenerated]
	public void set_direction(Vector3 value) { }

	[CompilerGenerated]
	public void set_distance(float value) { }

	public void set_layerMask(int value) { }

	[CompilerGenerated]
	public void set_origin(Vector3 value) { }

	[CompilerGenerated]
	public void set_physicsScene(PhysicsScene value) { }

	[CompilerGenerated]
	public void set_radius(float value) { }

}


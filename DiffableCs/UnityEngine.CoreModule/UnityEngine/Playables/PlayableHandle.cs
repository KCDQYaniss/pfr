namespace UnityEngine.Playables;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Export/Director/PlayableHandle.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[UsedByNativeCode]
public struct PlayableHandle : IEquatable
{
	private static readonly PlayableHandle m_Null; //Field offset: 0x0
	internal IntPtr m_Handle; //Field offset: 0x0
	internal uint m_Version; //Field offset: 0x8

	public static PlayableHandle Null
	{
		 get { } //Length: 101
	}

	private static PlayableHandle() { }

	internal bool CheckInputBounds(int inputIndex, bool acceptAny) { }

	internal bool CheckInputBounds(int inputIndex) { }

	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	public virtual bool Equals(object p) { }

	public override bool Equals(PlayableHandle other) { }

	public static PlayableHandle get_Null() { }

	[FreeFunction("PlayableHandleBindings::GetDuration", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal double GetDuration() { }

	private static double GetDuration_Injected(ref PlayableHandle _unity_self) { }

	[FreeFunction("PlayableHandleBindings::GetGraph", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal PlayableGraph GetGraph() { }

	private static void GetGraph_Injected(ref PlayableHandle _unity_self, out PlayableGraph ret) { }

	public virtual int GetHashCode() { }

	internal Playable GetInput(int inputPort) { }

	[FreeFunction("PlayableHandleBindings::GetInputCount", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal int GetInputCount() { }

	private static int GetInputCount_Injected(ref PlayableHandle _unity_self) { }

	[FreeFunction("PlayableHandleBindings::GetInputHandle", HasExplicitThis = True, ThrowsException = True)]
	private PlayableHandle GetInputHandle(int index) { }

	private static void GetInputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret) { }

	internal float GetInputWeight(int inputIndex) { }

	[FreeFunction("PlayableHandleBindings::GetInputWeightFromIndex", HasExplicitThis = True, ThrowsException = True)]
	private float GetInputWeightFromIndex(int index) { }

	private static float GetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index) { }

	internal T GetObject() { }

	[FreeFunction("PlayableHandleBindings::GetPlayableType", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal Type GetPlayableType() { }

	private static Type GetPlayableType_Injected(ref PlayableHandle _unity_self) { }

	[FreeFunction("PlayableHandleBindings::GetPlayState", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal PlayState GetPlayState() { }

	private static PlayState GetPlayState_Injected(ref PlayableHandle _unity_self) { }

	[FreeFunction("PlayableHandleBindings::GetPreviousTime", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal double GetPreviousTime() { }

	private static double GetPreviousTime_Injected(ref PlayableHandle _unity_self) { }

	[FreeFunction("PlayableHandleBindings::GetScriptInstance", HasExplicitThis = True, ThrowsException = True)]
	private object GetScriptInstance() { }

	private static object GetScriptInstance_Injected(ref PlayableHandle _unity_self) { }

	[FreeFunction("PlayableHandleBindings::GetTime", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal double GetTime() { }

	private static double GetTime_Injected(ref PlayableHandle _unity_self) { }

	[FreeFunction("PlayableHandleBindings::GetTimeWrapMode", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal DirectorWrapMode GetTimeWrapMode() { }

	private static DirectorWrapMode GetTimeWrapMode_Injected(ref PlayableHandle _unity_self) { }

	[FreeFunction("PlayableHandleBindings::IsDone", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal bool IsDone() { }

	private static bool IsDone_Injected(ref PlayableHandle _unity_self) { }

	[VisibleToOtherModules]
	internal bool IsPlayableOfType() { }

	[VisibleToOtherModules]
	internal bool IsValid() { }

	private static bool IsValid_Injected(ref PlayableHandle _unity_self) { }

	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	[FreeFunction("PlayableHandleBindings::Pause", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void Pause() { }

	private static void Pause_Injected(ref PlayableHandle _unity_self) { }

	[FreeFunction("PlayableHandleBindings::Play", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void Play() { }

	private static void Play_Injected(ref PlayableHandle _unity_self) { }

	[FreeFunction("PlayableHandleBindings::SetDone", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetDone(bool value) { }

	private static void SetDone_Injected(ref PlayableHandle _unity_self, bool value) { }

	[FreeFunction("PlayableHandleBindings::SetDuration", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetDuration(double value) { }

	private static void SetDuration_Injected(ref PlayableHandle _unity_self, double value) { }

	[FreeFunction("PlayableHandleBindings::SetInputCount", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetInputCount(int value) { }

	private static void SetInputCount_Injected(ref PlayableHandle _unity_self, int value) { }

	internal bool SetInputWeight(int inputIndex, float weight) { }

	[FreeFunction("PlayableHandleBindings::SetInputWeight", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetInputWeight(PlayableHandle input, float weight) { }

	private static void SetInputWeight_Injected(ref PlayableHandle _unity_self, ref PlayableHandle input, float weight) { }

	[FreeFunction("PlayableHandleBindings::SetInputWeightFromIndex", HasExplicitThis = True, ThrowsException = True)]
	private void SetInputWeightFromIndex(int index, float weight) { }

	private static void SetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index, float weight) { }

	[FreeFunction("PlayableHandleBindings::SetPropagateSetTime", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetPropagateSetTime(bool value) { }

	private static void SetPropagateSetTime_Injected(ref PlayableHandle _unity_self, bool value) { }

	[FreeFunction("PlayableHandleBindings::SetScriptInstance", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetScriptInstance(object scriptInstance) { }

	private static void SetScriptInstance_Injected(ref PlayableHandle _unity_self, object scriptInstance) { }

	[FreeFunction("PlayableHandleBindings::SetSpeed", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetSpeed(double value) { }

	private static void SetSpeed_Injected(ref PlayableHandle _unity_self, double value) { }

	[FreeFunction("PlayableHandleBindings::SetTime", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetTime(double value) { }

	private static void SetTime_Injected(ref PlayableHandle _unity_self, double value) { }

	[FreeFunction("PlayableHandleBindings::SetTimeWrapMode", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetTimeWrapMode(DirectorWrapMode mode) { }

	private static void SetTimeWrapMode_Injected(ref PlayableHandle _unity_self, DirectorWrapMode mode) { }

	[FreeFunction("PlayableHandleBindings::SetTraversalMode", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetTraversalMode(PlayableTraversalMode mode) { }

	private static void SetTraversalMode_Injected(ref PlayableHandle _unity_self, PlayableTraversalMode mode) { }

}


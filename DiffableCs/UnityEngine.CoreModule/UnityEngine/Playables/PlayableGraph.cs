namespace UnityEngine.Playables;

[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Export/Director/PlayableGraph.bindings.h")]
[UsedByNativeCode]
public struct PlayableGraph
{
	internal IntPtr m_Handle; //Field offset: 0x0
	internal uint m_Version; //Field offset: 0x8

	public bool Connect(U source, int sourceOutputPort, V destination, int destinationInputPort) { }

	[FreeFunction("PlayableGraphBindings::ConnectInternal", HasExplicitThis = True, ThrowsException = True)]
	private bool ConnectInternal(PlayableHandle source, int sourceOutputPort, PlayableHandle destination, int destinationInputPort) { }

	private static bool ConnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle source, int sourceOutputPort, ref PlayableHandle destination, int destinationInputPort) { }

	public static PlayableGraph Create() { }

	public static PlayableGraph Create(string name) { }

	private static void Create_Injected(string name, out PlayableGraph ret) { }

	[FreeFunction("PlayableGraphBindings::CreatePlayableHandle", HasExplicitThis = True, ThrowsException = True)]
	internal PlayableHandle CreatePlayableHandle() { }

	private static void CreatePlayableHandle_Injected(ref PlayableGraph _unity_self, out PlayableHandle ret) { }

	[FreeFunction("PlayableGraphBindings::CreateScriptOutputInternal", HasExplicitThis = True, ThrowsException = True)]
	internal bool CreateScriptOutputInternal(string name, out PlayableOutputHandle handle) { }

	private static bool CreateScriptOutputInternal_Injected(ref PlayableGraph _unity_self, string name, out PlayableOutputHandle handle) { }

	[FreeFunction("PlayableGraphBindings::Destroy", HasExplicitThis = True, ThrowsException = True)]
	public void Destroy() { }

	private static void Destroy_Injected(ref PlayableGraph _unity_self) { }

	public void Disconnect(U input, int inputPort) { }

	[FreeFunction("PlayableGraphBindings::DisconnectInternal", HasExplicitThis = True, ThrowsException = True)]
	private void DisconnectInternal(PlayableHandle playable, int inputPort) { }

	private static void DisconnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable, int inputPort) { }

	public void Evaluate() { }

	[FreeFunction("PlayableGraphBindings::Evaluate", HasExplicitThis = True, ThrowsException = True)]
	public void Evaluate(float deltaTime) { }

	private static void Evaluate_Injected(ref PlayableGraph _unity_self, float deltaTime) { }

	[FreeFunction("PlayableGraphBindings::GetFrameRate", HasExplicitThis = True, ThrowsException = True)]
	internal FrameRate GetFrameRate() { }

	private static void GetFrameRate_Injected(ref PlayableGraph _unity_self, out FrameRate ret) { }

	public PlayableOutput GetOutputByType(int index) { }

	[FreeFunction("PlayableGraphBindings::GetOutputByTypeInternal", HasExplicitThis = True, ThrowsException = True)]
	private bool GetOutputByTypeInternal(Type outputType, int index, out PlayableOutputHandle handle) { }

	private static bool GetOutputByTypeInternal_Injected(ref PlayableGraph _unity_self, Type outputType, int index, out PlayableOutputHandle handle) { }

	[FreeFunction("PlayableGraphBindings::GetPlayableCount", HasExplicitThis = True, ThrowsException = True)]
	public int GetPlayableCount() { }

	private static int GetPlayableCount_Injected(ref PlayableGraph _unity_self) { }

	[FreeFunction("PlayableGraphBindings::GetResolver", HasExplicitThis = True, ThrowsException = True)]
	public IExposedPropertyTable GetResolver() { }

	private static IExposedPropertyTable GetResolver_Injected(ref PlayableGraph _unity_self) { }

	public Playable GetRootPlayable(int index) { }

	[FreeFunction("PlayableGraphBindings::GetRootPlayableCount", HasExplicitThis = True, ThrowsException = True)]
	public int GetRootPlayableCount() { }

	private static int GetRootPlayableCount_Injected(ref PlayableGraph _unity_self) { }

	[FreeFunction("PlayableGraphBindings::GetRootPlayableInternal", HasExplicitThis = True, ThrowsException = True)]
	internal PlayableHandle GetRootPlayableInternal(int index) { }

	private static void GetRootPlayableInternal_Injected(ref PlayableGraph _unity_self, int index, out PlayableHandle ret) { }

	[FreeFunction("PlayableGraphBindings::IsMatchFrameRateEnabled", HasExplicitThis = True, ThrowsException = True)]
	internal bool IsMatchFrameRateEnabled() { }

	private static bool IsMatchFrameRateEnabled_Injected(ref PlayableGraph _unity_self) { }

	[FreeFunction("PlayableGraphBindings::IsPlaying", HasExplicitThis = True, ThrowsException = True)]
	public bool IsPlaying() { }

	private static bool IsPlaying_Injected(ref PlayableGraph _unity_self) { }

	public bool IsValid() { }

	private static bool IsValid_Injected(ref PlayableGraph _unity_self) { }

	[FreeFunction("PlayableGraphBindings::Play", HasExplicitThis = True, ThrowsException = True)]
	public void Play() { }

	private static void Play_Injected(ref PlayableGraph _unity_self) { }

	[FreeFunction("PlayableGraphBindings::SetTimeUpdateMode", HasExplicitThis = True, ThrowsException = True)]
	public void SetTimeUpdateMode(DirectorUpdateMode value) { }

	private static void SetTimeUpdateMode_Injected(ref PlayableGraph _unity_self, DirectorUpdateMode value) { }

	[FreeFunction("PlayableGraphBindings::Stop", HasExplicitThis = True, ThrowsException = True)]
	public void Stop() { }

	private static void Stop_Injected(ref PlayableGraph _unity_self) { }

	[FreeFunction("PlayableGraphBindings::SynchronizeEvaluation", HasExplicitThis = True, ThrowsException = True)]
	internal void SynchronizeEvaluation(PlayableGraph playable) { }

	private static void SynchronizeEvaluation_Injected(ref PlayableGraph _unity_self, ref PlayableGraph playable) { }

}


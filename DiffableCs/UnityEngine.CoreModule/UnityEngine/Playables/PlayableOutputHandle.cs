namespace UnityEngine.Playables;

[NativeHeader("Runtime/Export/Director/PlayableOutputHandle.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[UsedByNativeCode]
public struct PlayableOutputHandle : IEquatable
{
	private static readonly PlayableOutputHandle m_Null; //Field offset: 0x0
	internal IntPtr m_Handle; //Field offset: 0x0
	internal uint m_Version; //Field offset: 0x8

	public static PlayableOutputHandle Null
	{
		 get { } //Length: 101
	}

	private static PlayableOutputHandle() { }

	[FreeFunction("PlayableOutputHandleBindings::AddNotificationReceiver", HasExplicitThis = True, ThrowsException = True)]
	internal void AddNotificationReceiver(INotificationReceiver receiver) { }

	private static void AddNotificationReceiver_Injected(ref PlayableOutputHandle _unity_self, INotificationReceiver receiver) { }

	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	public virtual bool Equals(object p) { }

	public override bool Equals(PlayableOutputHandle other) { }

	public static PlayableOutputHandle get_Null() { }

	public virtual int GetHashCode() { }

	[FreeFunction("PlayableOutputHandleBindings::GetPlayableOutputType", HasExplicitThis = True, ThrowsException = True)]
	internal Type GetPlayableOutputType() { }

	private static Type GetPlayableOutputType_Injected(ref PlayableOutputHandle _unity_self) { }

	[FreeFunction("PlayableOutputHandleBindings::GetSourceOutputPort", HasExplicitThis = True, ThrowsException = True)]
	internal int GetSourceOutputPort() { }

	private static int GetSourceOutputPort_Injected(ref PlayableOutputHandle _unity_self) { }

	[FreeFunction("PlayableOutputHandleBindings::GetSourcePlayable", HasExplicitThis = True, ThrowsException = True)]
	internal PlayableHandle GetSourcePlayable() { }

	private static void GetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, out PlayableHandle ret) { }

	[FreeFunction("PlayableOutputHandleBindings::GetWeight", HasExplicitThis = True, ThrowsException = True)]
	internal float GetWeight() { }

	private static float GetWeight_Injected(ref PlayableOutputHandle _unity_self) { }

	[VisibleToOtherModules]
	internal bool IsPlayableOutputOfType() { }

	[VisibleToOtherModules]
	internal bool IsValid() { }

	private static bool IsValid_Injected(ref PlayableOutputHandle _unity_self) { }

	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	[FreeFunction("PlayableOutputHandleBindings::PushNotification", HasExplicitThis = True, ThrowsException = True)]
	internal void PushNotification(PlayableHandle origin, INotification notification, object context) { }

	private static void PushNotification_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle origin, INotification notification, object context) { }

	[FreeFunction("PlayableOutputHandleBindings::SetReferenceObject", HasExplicitThis = True, ThrowsException = True)]
	internal void SetReferenceObject(Object target) { }

	private static void SetReferenceObject_Injected(ref PlayableOutputHandle _unity_self, Object target) { }

	[FreeFunction("PlayableOutputHandleBindings::SetSourcePlayable", HasExplicitThis = True, ThrowsException = True)]
	internal void SetSourcePlayable(PlayableHandle target, int port) { }

	private static void SetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle target, int port) { }

	[FreeFunction("PlayableOutputHandleBindings::SetUserData", HasExplicitThis = True, ThrowsException = True)]
	internal void SetUserData(Object target) { }

	private static void SetUserData_Injected(ref PlayableOutputHandle _unity_self, Object target) { }

	[FreeFunction("PlayableOutputHandleBindings::SetWeight", HasExplicitThis = True, ThrowsException = True)]
	internal void SetWeight(float weight) { }

	private static void SetWeight_Injected(ref PlayableOutputHandle _unity_self, float weight) { }

}


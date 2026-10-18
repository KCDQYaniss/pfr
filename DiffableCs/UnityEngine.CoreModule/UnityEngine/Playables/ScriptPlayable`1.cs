namespace UnityEngine.Playables;

public struct ScriptPlayable`1 : IPlayable, IEquatable
{
	private static readonly ScriptPlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	public static ScriptPlayable Null
	{
		 get { } //Length: 164
	}

	private static ScriptPlayable`1() { }

	internal ScriptPlayable`1(PlayableHandle handle) { }

	private static object CloneScriptInstance(IPlayableBehaviour source) { }

	private static object CloneScriptInstanceFromEngineObject(Object source) { }

	private static object CloneScriptInstanceFromIClonable(ICloneable source) { }

	public static ScriptPlayable Create(PlayableGraph graph, int inputCount = 0) { }

	public static ScriptPlayable Create(PlayableGraph graph, T template, int inputCount = 0) { }

	private static PlayableHandle CreateHandle(PlayableGraph graph, T template, int inputCount) { }

	private static object CreateScriptInstance() { }

	public override bool Equals(ScriptPlayable other) { }

	public static ScriptPlayable get_Null() { }

	public T GetBehaviour() { }

	public override PlayableHandle GetHandle() { }

	public static ScriptPlayable op_Explicit(Playable playable) { }

	public static Playable op_Implicit(ScriptPlayable playable) { }

}


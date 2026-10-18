namespace UnityEngine.Rendering.PostProcessing;

internal class TargetPool
{
	private readonly List m_Pool; //Field offset: 0x10
	private int m_Current; //Field offset: 0x18

	internal TargetPool() { }

	internal int Get() { }

	private int Get(int i) { }

	internal void Reset() { }

}


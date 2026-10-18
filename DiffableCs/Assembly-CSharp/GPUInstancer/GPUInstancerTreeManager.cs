namespace GPUInstancer;

[ExecuteInEditMode]
public class GPUInstancerTreeManager : GPUInstancerTerrainManager
{
	[CompilerGenerated]
	private sealed class <ReplaceUnityTrees>d__7 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public GPUInstancerTreeManager <>4__this; //Field offset: 0x20
		private int <instanceTotal>5__2; //Field offset: 0x28
		private Vector4[] <treeScales>5__3; //Field offset: 0x30
		private Vector4[] <treeDataArray>5__4; //Field offset: 0x38
		private int[] <instanceCounts>5__5; //Field offset: 0x40
		private ComputeBuffer <treeDataBuffer>5__6; //Field offset: 0x48
		private ComputeBuffer <treeScalesBuffer>5__7; //Field offset: 0x50
		private ComputeBuffer <counterBuffer>5__8; //Field offset: 0x58
		private uint[] <emptyCounterData>5__9; //Field offset: 0x60
		private int <i>5__10; //Field offset: 0x68

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <ReplaceUnityTrees>d__7(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static ComputeShader _treeInstantiationComputeShader; //Field offset: 0x0
	public bool initializeWithCoroutine; //Field offset: 0xE0

	public GPUInstancerTreeManager() { }

	public virtual void Awake() { }

	public virtual void ClearInstancingData() { }

	public virtual void DeletePrototype(GPUInstancerPrototype prototype, bool removeSO = true) { }

	public virtual void GeneratePrototypes(bool forceNew = false) { }

	public virtual void InitializeRuntimeDataAndBuffers(bool forceNew = true) { }

	[IteratorStateMachine(typeof(<ReplaceUnityTrees>d__7))]
	public IEnumerator ReplaceUnityTrees() { }

}


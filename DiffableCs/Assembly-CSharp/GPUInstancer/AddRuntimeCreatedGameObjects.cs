namespace GPUInstancer;

public class AddRuntimeCreatedGameObjects : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <AddRemoveAtRuntime>d__6 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AddRuntimeCreatedGameObjects <>4__this; //Field offset: 0x20
		private IEnumerator <>7__wrap1; //Field offset: 0x28
		private PrimitiveType <primitiveType>5__3; //Field offset: 0x30

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
		public <AddRemoveAtRuntime>d__6(int <>1__state) { }

		private void <>m__Finally1() { }

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

	public GPUInstancerPrefabManager prefabManager; //Field offset: 0x20
	public Material material; //Field offset: 0x28
	private List instanceList; //Field offset: 0x30
	private GPUInstancerPrefabPrototype prototype; //Field offset: 0x38
	private GameObject prototypeGameObject; //Field offset: 0x40

	public AddRuntimeCreatedGameObjects() { }

	[IteratorStateMachine(typeof(<AddRemoveAtRuntime>d__6))]
	private IEnumerator AddRemoveAtRuntime() { }

	public void ClearInstances() { }

	public void SetMaterial() { }

	private void Start() { }

}


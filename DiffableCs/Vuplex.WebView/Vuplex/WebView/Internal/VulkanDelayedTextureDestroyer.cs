namespace Vuplex.WebView.Internal;

public class VulkanDelayedTextureDestroyer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <_destroyTexturesPeriodically>d__8 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public VulkanDelayedTextureDestroyer <>4__this; //Field offset: 0x20

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
		public <_destroyTexturesPeriodically>d__8(int <>1__state) { }

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

	private static VulkanDelayedTextureDestroyer _instance; //Field offset: 0x0
	private Action _destroyVulkanTextureFunction; //Field offset: 0x20
	private int _indexOfTextureListActiveForDiscarding; //Field offset: 0x28
	private List[] _textureLists; //Field offset: 0x30
	private WaitForSeconds _waitShortDelay; //Field offset: 0x38

	[IteratorStateMachine(typeof(<_destroyTexturesPeriodically>d__8))]
	private IEnumerator _destroyTexturesPeriodically() { }

	public VulkanDelayedTextureDestroyer() { }

	public void DestroyTexture(IntPtr nativeTexture) { }

	public static VulkanDelayedTextureDestroyer GetInstance(Action destroyVulkanTextureFunction) { }

	private void OnEnable() { }

}


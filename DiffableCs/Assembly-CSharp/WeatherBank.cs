//Type is in global namespace

public class WeatherBank : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <ImplementConfigNodeCoroutine>d__9 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public WeatherConfigItem weatherConfigItem; //Field offset: 0x20

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
		public <ImplementConfigNodeCoroutine>d__9(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <UseWeatherConfigCoroutine>d__7 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public WeatherBank <>4__this; //Field offset: 0x20
		public string configId; //Field offset: 0x28
		private WeatherConfigItem <weatherConfigItem>5__2; //Field offset: 0x30

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
		public <UseWeatherConfigCoroutine>d__7(int <>1__state) { }

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

	public List weatherConfigs; //Field offset: 0x20
	private Action _unsubscribeOnDestroy; //Field offset: 0x28
	private CloudLayer _defaultCloudLayer; //Field offset: 0x30

	public WeatherBank() { }

	private void ActivateWeatherConfigHandler(ActivateWeatherConfigEvent activateEvent) { }

	private void ImplementCloudSettings(WeatherConfigItem weatherConfigItem) { }

	[IteratorStateMachine(typeof(<ImplementConfigNodeCoroutine>d__9))]
	private IEnumerator ImplementConfigNodeCoroutine(WeatherConfigItem weatherConfigItem) { }

	private void OnDestroy() { }

	private void Start() { }

	public void UseWeatherConfig(string configId) { }

	[IteratorStateMachine(typeof(<UseWeatherConfigCoroutine>d__7))]
	public IEnumerator UseWeatherConfigCoroutine(string configId) { }

}


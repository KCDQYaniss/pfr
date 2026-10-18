namespace Audio.SpatialSystem;

public class AudioBakeDataReader
{
	[CompilerGenerated]
	private sealed class <ReadAndWriteToDataContainerCoroutine>d__4 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public string pathToLoad; //Field offset: 0x20
		public SpatialAudioDataContainer container; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		public AudioBakeDataReader <>4__this; //Field offset: 0x38
		public Action onDone; //Field offset: 0x40
		private HashSet <missingRoomPairIds>5__2; //Field offset: 0x48
		private FileStream <stream>5__3; //Field offset: 0x50
		private BinaryReader <reader>5__4; //Field offset: 0x58

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
		public <ReadAndWriteToDataContainerCoroutine>d__4(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

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
	private sealed class <ReadRoomPairs>d__5 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AudioBakeDataReader <>4__this; //Field offset: 0x20
		public SpatialAudioDataContainer container; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		public BinaryReader reader; //Field offset: 0x38
		private int <roomPairsItemsCount>5__2; //Field offset: 0x40
		private int <i>5__3; //Field offset: 0x44

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
		public <ReadRoomPairs>d__5(int <>1__state) { }

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
	private sealed class <ReadRoutesAwareRoomItems>d__6 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AudioBakeDataReader <>4__this; //Field offset: 0x20
		public SpatialAudioDataContainer container; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		public BinaryReader reader; //Field offset: 0x38
		public HashSet missingRoomPairIds; //Field offset: 0x40
		private int <routesAwareRoomItemsCount>5__2; //Field offset: 0x48
		private int <i>5__3; //Field offset: 0x4C
		private short <roomID>5__4; //Field offset: 0x50
		private int <length>5__5; //Field offset: 0x54
		private int <k>5__6; //Field offset: 0x58

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
		public <ReadRoutesAwareRoomItems>d__6(int <>1__state) { }

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
	private sealed class <ReadRoutesByRoomPairIDItems>d__7 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AudioBakeDataReader <>4__this; //Field offset: 0x20
		public SpatialAudioDataContainer container; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		public BinaryReader reader; //Field offset: 0x38
		private int <routesByRoomPairIDItemsCount>5__2; //Field offset: 0x40
		private int <i>5__3; //Field offset: 0x44

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
		public <ReadRoutesByRoomPairIDItems>d__7(int <>1__state) { }

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

	private const short MAX_ITERATION_PER_FRAME = 300; //Field offset: 0x0
	private int _iterationCount; //Field offset: 0x10

	private bool HasReachedMaxIterationsPerFrame
	{
		private get { } //Length: 31
	}

	public AudioBakeDataReader() { }

	private bool get_HasReachedMaxIterationsPerFrame() { }

	[IteratorStateMachine(typeof(<ReadAndWriteToDataContainerCoroutine>d__4))]
	public IEnumerator ReadAndWriteToDataContainerCoroutine(string pathToLoad, SpatialAudioDataContainer container, CancellationToken cancellationToken, Action onDone = null, Action onError = null) { }

	private AudioRouteData[] ReadAudioRouteDataArray(BinaryReader reader) { }

	[IteratorStateMachine(typeof(<ReadRoomPairs>d__5))]
	private IEnumerator ReadRoomPairs(BinaryReader reader, SpatialAudioDataContainer container, CancellationToken cancellationToken) { }

	[IteratorStateMachine(typeof(<ReadRoutesAwareRoomItems>d__6))]
	private IEnumerator ReadRoutesAwareRoomItems(BinaryReader reader, SpatialAudioDataContainer container, CancellationToken cancellationToken, HashSet missingRoomPairIds) { }

	[IteratorStateMachine(typeof(<ReadRoutesByRoomPairIDItems>d__7))]
	private IEnumerator ReadRoutesByRoomPairIDItems(BinaryReader reader, SpatialAudioDataContainer container, CancellationToken cancellationToken) { }

}


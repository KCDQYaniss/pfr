namespace EFT;

public sealed class TraderServicesHandler
{
	[CompilerGenerated]
	private sealed class <GetEligibleServices>d__1 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ServiceData <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private MongoID traderId; //Field offset: 0x28
		public MongoID <>3__traderId; //Field offset: 0x40
		public TraderServicesHandler <>4__this; //Field offset: 0x58
		private QuestController questControllerServer; //Field offset: 0x60
		public QuestController <>3__questControllerServer; //Field offset: 0x68
		private Dictionary traderInfos; //Field offset: 0x70
		public Dictionary <>3__traderInfos; //Field offset: 0x78
		private Enumerator <>7__wrap1; //Field offset: 0x80

		private override ServiceData System.Collections.Generic.IEnumerator<EFT.GlobalConfiguration.ServiceData>.Current
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
		public <GetEligibleServices>d__1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.GlobalConfiguration.ServiceData>.GetEnumerator() { }

		[DebuggerHidden]
		private override ServiceData System.Collections.Generic.IEnumerator<EFT.GlobalConfiguration.ServiceData>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	public TraderServicesHandler() { }

	[IteratorStateMachine(typeof(<GetEligibleServices>d__1))]
	public IEnumerable GetEligibleServices(MongoID traderId, QuestController questControllerServer, Dictionary traderInfos) { }

	private bool IsServiceEligible(ServiceData service, QuestController questControllerServer, Dictionary traderInfos) { }

}


namespace EFT.SeasonalPerks;

[JsonObject(MemberSerialization::OptIn (1))]
public sealed class SeasonalPerkAllergySubEffects
{
	[CompilerGenerated]
	private sealed class <get_AllEffects>d__8 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private SeasonalPerkSubEffect <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public SeasonalPerkAllergySubEffects <>4__this; //Field offset: 0x28

		private override SeasonalPerkSubEffect System.Collections.Generic.IEnumerator<EFT.SeasonalPerks.SeasonalPerkSubEffect>.Current
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
		public <get_AllEffects>d__8(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.SeasonalPerks.SeasonalPerkSubEffect>.GetEnumerator() { }

		[DebuggerHidden]
		private override SeasonalPerkSubEffect System.Collections.Generic.IEnumerator<EFT.SeasonalPerks.SeasonalPerkSubEffect>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[JsonProperty("pain")]
	public readonly PainPerkSubEffect Pain; //Field offset: 0x10
	[JsonProperty("onPainkillers")]
	public readonly PainkillerPerkSubEffect Painkiller; //Field offset: 0x18
	[JsonProperty("tremor")]
	public readonly TremorPerkSubEffect Tremor; //Field offset: 0x20
	[JsonProperty("tunnelVision")]
	public readonly TunnelVisionPerkSubEffect TunnelVision; //Field offset: 0x28
	[JsonProperty("healthRegeneration")]
	public readonly HealthRegenerationSubEffect HealthRegeneration; //Field offset: 0x30
	[JsonProperty("hydrationRecovery")]
	public readonly HydrationRecoverySubEffect HydrationRecovery; //Field offset: 0x38
	[JsonProperty("energyRecovery")]
	public readonly EnergyRecoverySubEffect EnergyRecovery; //Field offset: 0x40

	public IEnumerable AllEffects
	{
		[IteratorStateMachine(typeof(<get_AllEffects>d__8))]
		 get { } //Length: 175
	}

	public SeasonalPerkAllergySubEffects() { }

	[IteratorStateMachine(typeof(<get_AllEffects>d__8))]
	public IEnumerable get_AllEffects() { }

}


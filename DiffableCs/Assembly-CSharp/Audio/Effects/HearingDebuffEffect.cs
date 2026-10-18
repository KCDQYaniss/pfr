namespace Audio.Effects;

public sealed class HearingDebuffEffect : IHearingDebuffEffect
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public HearingDebuffEffect <>4__this; //Field offset: 0x10
		public Action onComplete; //Field offset: 0x18
		public Sequence seq; //Field offset: 0x20

		public <>c__DisplayClass4_0() { }

		internal void <SetDebuff>b__0() { }

		internal void <SetDebuff>b__1() { }

	}

	public const string WORLD_MIXER_HEARING_TWEEN_GROUP_ID = "HearingDebuff_WorldMixer"; //Field offset: 0x0
	private readonly FirstPersonPlayerHearingSettings _settings; //Field offset: 0x10
	private Sequence _sequence; //Field offset: 0x18

	public HearingDebuffEffect(FirstPersonPlayerHearingSettings settings) { }

	public override void Reset() { }

	public override void SetDebuff(float debuffPercentage, float fadeTime = 1, Action onComplete = null) { }

}


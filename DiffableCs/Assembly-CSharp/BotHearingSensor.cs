//Type is in global namespace

public class BotHearingSensor
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public BotHearingSensor <>4__this; //Field offset: 0x10
		public IPlayer player; //Field offset: 0x18
		public Vector3 position; //Field offset: 0x20
		public float power; //Field offset: 0x2C
		public AISoundType type; //Field offset: 0x30

		public <>c__DisplayClass5_0() { }

		internal void <OnSoundPlayed>b__0() { }

	}

	private readonly BotOwner _botOwner; //Field offset: 0x10
	private readonly BotSettings _botSettings; //Field offset: 0x18
	public OnEnemySounHeardedDelegate OnEnemySounHearded; //Field offset: 0x20

	public BotHearingSensor(BotOwner onwer) { }

	private bool CheckSoundDirection(Vector3 from, Vector3 to, Vector3 dir, float dist, float maxSDist) { }

	private bool CheckSoundDirectionProjection(Vector3 from, Vector3 to, float maxSDist) { }

	public void Dispose() { }

	public void Init() { }

	private bool IsSImpleSoundHeard(float d) { }

	private bool IsSoundDiretedToMe(BotOwner bot, float bDist, Vector3 dir, Vector3 bDir) { }

	private bool IsSoundHeard(Vector3 position, float power, AISoundType type, out float dist) { }

	private void OnSoundPlayed(IPlayer player, Vector3 position, float power, AISoundType type) { }

	private void OnSoundPlayedInner(IPlayer player, Vector3 position, float power, AISoundType type) { }

	private void SoundHeared(IPlayer enemy, Vector3 pos, float power, bool wasHeard, AISoundType type) { }

}


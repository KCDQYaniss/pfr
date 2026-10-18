namespace EFT;

public sealed class FrostbiteEffectAudioPlayer : IEffectAudioPlayer, IDisposable
{
	private readonly TagBank _soundBank; //Field offset: 0x10
	private readonly Player _player; //Field offset: 0x18
	private readonly EnvironmentManager _environmentManager; //Field offset: 0x20
	private int _ticksPerPlay; //Field offset: 0x28
	private int _playCounter; //Field offset: 0x2C
	private Action _unsubOnDispose; //Field offset: 0x30

	public FrostbiteEffectAudioPlayer(Player player, TagBank soundBank) { }

	public override void Dispose() { }

	public override void Play() { }

	public override void ResetCounter() { }

	public override void SetTickPerPlay(int count) { }

	public override void Stop() { }

}


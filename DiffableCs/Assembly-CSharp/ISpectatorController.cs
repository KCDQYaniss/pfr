//Type is in global namespace

public interface ISpectatorController
{
	internal sealed class SpectatorChangedDelegate : MulticastDelegate
	{

		public SpectatorChangedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int raidId, Dictionary health, Dictionary healthEffects, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int raidId, Dictionary health, Dictionary healthEffects) { }

	}

	internal sealed class SpectatorHealthChangedDelegate : MulticastDelegate
	{

		public SpectatorHealthChangedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int raidId, EBodyPart bodyPart, float health, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int raidId, EBodyPart bodyPart, float health) { }

	}

	internal sealed class SpectatorHealthEffectDisplayChangedDelegate : MulticastDelegate
	{

		public SpectatorHealthEffectDisplayChangedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int raidId, bool clear, EHealthEffectType effect, int count, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int raidId, bool clear, EHealthEffectType effect, int count) { }

	}

	internal sealed class TeammateDeathDelegate : MulticastDelegate
	{

		public TeammateDeathDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int raidId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int raidId) { }

	}

	internal sealed class WhiteNoiseEffectStatusChangedDelegate : MulticastDelegate
	{

		public WhiteNoiseEffectStatusChangedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool enable, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool enable) { }

	}


	public event SpectatorHealthEffectDisplayChangedDelegate OnHealthEffectDisplayChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event SpectatorChangedDelegate OnSpectatorChange
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event SpectatorHealthChangedDelegate OnSpectatorHealthChange
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event TeammateDeathDelegate OnTeammateDeath
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event WhiteNoiseEffectStatusChangedDelegate OnWhiteNoiseEffectStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnHealthEffectDisplayChanged(SpectatorHealthEffectDisplayChangedDelegate value) { }

	[CompilerGenerated]
	public void add_OnSpectatorChange(SpectatorChangedDelegate value) { }

	[CompilerGenerated]
	public void add_OnSpectatorHealthChange(SpectatorHealthChangedDelegate value) { }

	[CompilerGenerated]
	public void add_OnTeammateDeath(TeammateDeathDelegate value) { }

	[CompilerGenerated]
	public void add_OnWhiteNoiseEffectStatusChanged(WhiteNoiseEffectStatusChangedDelegate value) { }

	public IReadOnlyDictionary GetHealthStatus(int raidId) { }

	public bool GetWhiteNoiseStatus(int raidId) { }

	public bool IsTeammateAlive(int raidId) { }

	[CompilerGenerated]
	public void remove_OnHealthEffectDisplayChanged(SpectatorHealthEffectDisplayChangedDelegate value) { }

	[CompilerGenerated]
	public void remove_OnSpectatorChange(SpectatorChangedDelegate value) { }

	[CompilerGenerated]
	public void remove_OnSpectatorHealthChange(SpectatorHealthChangedDelegate value) { }

	[CompilerGenerated]
	public void remove_OnTeammateDeath(TeammateDeathDelegate value) { }

	[CompilerGenerated]
	public void remove_OnWhiteNoiseEffectStatusChanged(WhiteNoiseEffectStatusChangedDelegate value) { }

	public void ResetCameraEffects() { }

	public void StopSpectating() { }

	public bool TryGetPlayerIcon(int raidId, out PlayerIconRequest iconRequest) { }

}


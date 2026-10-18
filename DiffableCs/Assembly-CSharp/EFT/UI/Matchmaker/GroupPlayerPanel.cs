namespace EFT.UI.Matchmaker;

public class GroupPlayerPanel : AbstractGroupPlayerPanel
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public string youStatus; //Field offset: 0x10
		public GroupPlayerPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal void <Show>b__0(RaidPlayer owner) { }

	}

	[SerializeField]
	private Color _defaultImageColor; //Field offset: 0xC0
	[SerializeField]
	private Color _readyColor; //Field offset: 0xD0
	[SerializeField]
	private Color _notReadyColor; //Field offset: 0xE0
	private bool _isLeaderReady; //Field offset: 0xF0

	public GroupPlayerPanel() { }

	protected virtual void SetBackgroundImage(bool hover) { }

	public virtual void Show(RaidPlayer player, UpdatableChatMember friendMember, string profileAid, BindableState groupOwner) { }

	private void UpdateBackgroundImage() { }

	private void UpdateLeaderStatus() { }

}


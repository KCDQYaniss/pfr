namespace EFT.UI;

public class BattleUIPanelDeath : BattleUIPanel
{
	[SerializeField]
	private CustomTextMeshProUGUI _nickname; //Field offset: 0x78
	[SerializeField]
	private CustomTextMeshProUGUI _time; //Field offset: 0x80
	[SerializeField]
	private GameObject _survivedPanel; //Field offset: 0x88
	[SerializeField]
	private GameObject _leftPanel; //Field offset: 0x90
	[SerializeField]
	private GameObject _missingPanel; //Field offset: 0x98
	[SerializeField]
	private GameObject _killedPanel; //Field offset: 0xA0
	[SerializeField]
	private GameObject _runnerPanel; //Field offset: 0xA8
	[SerializeField]
	private BattleUIPanelExitTrigger _battleUiPanelExitTrigger; //Field offset: 0xB0
	private Coroutine _showInfoPanelCoroutine; //Field offset: 0xB8

	public BattleUIPanelDeath() { }

	public virtual void Close() { }

	public void Show(Profile activeProfile, ExitStatus exitStatus, TimeSpan playTime) { }

	protected void StopShowingPanel() { }

}


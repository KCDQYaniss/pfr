namespace EFT.UI;

[UsedImplicitly]
public sealed class GameUI : MonoBehaviourSingleton
{
	[SerializeField]
	public ExtractionTimersPanel TimerPanel; //Field offset: 0x20
	[SerializeField]
	public BattleUIPanelDeath BattleUiPanelDeath; //Field offset: 0x28
	[SerializeField]
	public GameObject BattleUiInvalidEPPanel; //Field offset: 0x30
	[SerializeField]
	public BattleUIPanelExitTrigger BattleUiPanelExitTrigger; //Field offset: 0x38
	[SerializeField]
	public BattleUIPanelExtraction BattleUiPanelExtraction; //Field offset: 0x40
	[SerializeField]
	public BattleUIPmcCount BattleUiPmcCount; //Field offset: 0x48
	[SerializeField]
	public UsingPanel UsingPanel; //Field offset: 0x50
	[SerializeField]
	public BattleUIBtrSeatsCount BattleUiBtrSeatsCount; //Field offset: 0x58
	[SerializeField]
	public PostFXPreviewScreen PostFXPreview; //Field offset: 0x60
	[SerializeField]
	public LocationTransitGroupSize LocationTransitGroupSize; //Field offset: 0x68
	[SerializeField]
	public LocationTransitTimerPanel LocationTransitTimerPanel; //Field offset: 0x70
	[SerializeField]
	public EventStatePanel EventStatePanel; //Field offset: 0x78
	[SerializeField]
	public PasscodeInputPanel PasscodeInputPanel; //Field offset: 0x80
	[SerializeField]
	public CutsceneSkipUI CutsceneSkipUI; //Field offset: 0x88

	public GameUI() { }

	public virtual void OnDestroy() { }

}


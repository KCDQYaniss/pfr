namespace EFT;

[CreateAssetMenu(menuName = "Scriptable objects/StartZoneTriggersConfig", fileName = "StartZoneTriggersConfig")]
public class StartZoneTriggersConfig : ScriptableObject
{
	[SerializeField]
	private List _triggers; //Field offset: 0x18
	public TutorialHintData GrenadeHint; //Field offset: 0x20
	public TutorialHintData BleedHint; //Field offset: 0x28
	public TutorialHintData FractureHint; //Field offset: 0x30
	public TutorialHintData MalfHint; //Field offset: 0x38
	public TutorialHintData HydrationHint; //Field offset: 0x40
	public TutorialHintData TimerHint; //Field offset: 0x48
	public TutorialHintData FinalHint; //Field offset: 0x50
	public TutorialHintData ExaminationHint; //Field offset: 0x58

	public IReadOnlyList Triggers
	{
		 get { } //Length: 5
	}

	public StartZoneTriggersConfig() { }

	public IReadOnlyList get_Triggers() { }

	public static StartZoneTriggersConfig Load() { }

	public bool TryGetCommonTriggersData(int triggerHash, out TutorialHintData data, out bool isShowKey) { }

}


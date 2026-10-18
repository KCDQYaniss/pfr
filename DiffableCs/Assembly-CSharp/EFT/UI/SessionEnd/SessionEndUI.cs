namespace EFT.UI.SessionEnd;

public sealed class SessionEndUI : MonoBehaviourSingleton
{
	public SessionResultExitStatus SessionResultExitStatus; //Field offset: 0x20
	public SessionResultKillList SessionResultKillList; //Field offset: 0x28
	public SessionResultStatistics SessionResultStatistics; //Field offset: 0x30
	public SessionResultExperienceCount SessionResultExperienceCount; //Field offset: 0x38
	public HealthTreatmentScreen HealthTreatmentScreen; //Field offset: 0x40
	public OtherPlayerProfileScreen OtherPlayerProfileScreen; //Field offset: 0x48

	public SessionEndUI() { }

	public virtual void Awake() { }

	public virtual void OnDestroy() { }

}


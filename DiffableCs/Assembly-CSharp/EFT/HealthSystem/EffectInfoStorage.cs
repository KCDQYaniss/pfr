namespace EFT.HealthSystem;

public struct EffectInfoStorage
{
	public int ID; //Field offset: 0x0
	public IHealthController HealthController; //Field offset: 0x8
	public Type Type; //Field offset: 0x10
	public EBodyPart BodyPart; //Field offset: 0x18
	public float Strength; //Field offset: 0x1C
	public float CurrentStrength; //Field offset: 0x20
	public float DelayTime; //Field offset: 0x24
	public float StateTime; //Field offset: 0x28
	public float WorkStateTime; //Field offset: 0x2C
	public float BuildUpTime; //Field offset: 0x30
	public float ResidueStateTime; //Field offset: 0x34
	public int UpdateTime; //Field offset: 0x38
	public EEffectState State; //Field offset: 0x3C

	public void SaveInfo(int id, IHealthController hController, Type type, EBodyPart bodyPart, float strength, float currentStrength, float delayTime, float stateTime, float workStateTime, float buildUpTime, float residueStateTime, EEffectState state) { }

}


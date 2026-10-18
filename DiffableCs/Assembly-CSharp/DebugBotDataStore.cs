//Type is in global namespace

public class DebugBotDataStore
{
	public bool autoRespawn; //Field offset: 0x10
	public int respawnCount; //Field offset: 0x14
	public int SummonSavages; //Field offset: 0x18
	public bool evenlyDistribute; //Field offset: 0x1C
	public bool useStartWaves; //Field offset: 0x1D
	public bool badVision; //Field offset: 0x1E
	public bool badHearing; //Field offset: 0x1F
	public bool spawnInstantly; //Field offset: 0x20
	public List StartWaves; //Field offset: 0x28
	public List BossStartWaves; //Field offset: 0x30
	public bool useThisData; //Field offset: 0x38
	public bool NoMinMax; //Field offset: 0x39
	public bool NoSleepMode; //Field offset: 0x3A
	public bool TrueAim; //Field offset: 0x3B
	public bool FreeForAll; //Field offset: 0x3C
	public bool FreeForAllOverride; //Field offset: 0x3D
	public bool PhraseRequestAlwaysGood; //Field offset: 0x3E
	public bool UseDebugBrain; //Field offset: 0x3F
	public DebugBotDesition DebugBotDesition; //Field offset: 0x40
	public float FogMaxDebuffDistanceK; //Field offset: 0x44
	public float RainMaxDebuffDistanceK; //Field offset: 0x48
	public bool goodShooting; //Field offset: 0x4C

	public DebugBotDataStore() { }

	public DebugBotDataStore(DebugBotData debugBotData) { }

}


namespace EFT;

public struct CutsceneInteractionPacket
{
	public int CutsceneSceneNameHash; //Field offset: 0x0
	public int CutsceneID; //Field offset: 0x4
	public bool IsStarted; //Field offset: 0x8
	public Vector3 TransformPosition; //Field offset: 0xC

}


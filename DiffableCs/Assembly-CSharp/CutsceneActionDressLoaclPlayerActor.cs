//Type is in global namespace

public class CutsceneActionDressLoaclPlayerActor : CutsceneBaseAction
{
	public string actorName; //Field offset: 0x40
	public string actorBodyName; //Field offset: 0x48
	public string actorPantsName; //Field offset: 0x50
	public string headPartName; //Field offset: 0x58
	public Vector3 boundsCenter; //Field offset: 0x60
	public Vector3 boundsSize; //Field offset: 0x6C
	private Bounds _overrideBounds; //Field offset: 0x78
	[HideInInspector]
	public GameObject actorGameObject; //Field offset: 0x90
	[HideInInspector]
	public SkinnedMeshRenderer bodyRenderer; //Field offset: 0x98
	[HideInInspector]
	public SkinnedMeshRenderer pantRenderer; //Field offset: 0xA0
	[HideInInspector]
	public SkinnedMeshRenderer headRenderer; //Field offset: 0xA8
	public bool useDefaultSkinBySide; //Field offset: 0xB0
	public Mesh defaultBearBodyMesh; //Field offset: 0xB8
	public Mesh defaultBearPantMesh; //Field offset: 0xC0
	public Mesh defaultUsecBodyMesh; //Field offset: 0xC8
	public Mesh defaultUsecPantMesh; //Field offset: 0xD0
	public Material defaultBearBodyMat; //Field offset: 0xD8
	public Material defaultBearPantMat; //Field offset: 0xE0
	public Material defaultUsecBodyMat; //Field offset: 0xE8
	public Material defaultUsecPantMat; //Field offset: 0xF0

	public CutsceneActionDressLoaclPlayerActor() { }

	private void GetActorRenderers() { }

	public virtual void Init() { }

	private void SetRendererToPart(AbstractSkin fromSkin, SkinnedMeshRenderer to, Skeleton skeleton) { }

}


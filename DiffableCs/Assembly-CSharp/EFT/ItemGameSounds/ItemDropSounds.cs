namespace EFT.ItemGameSounds;

[CreateAssetMenu(fileName = "ItemDropSounds", menuName = "Audio/Item Drop Sounds")]
public class ItemDropSounds : ScriptableObject
{
	[SerializeField]
	private ESurfaceSound _fallbackSurface; //Field offset: 0x18
	[SerializeField]
	public AnimationCurve ImpactToVolumeCurve; //Field offset: 0x20
	[SerializeField]
	private List _profiles; //Field offset: 0x28
	private readonly Dictionary _lookupMap; //Field offset: 0x30

	public ItemDropSounds() { }

	public void RebuildLookupMap() { }

	public bool TryGetImpactBank(ESurfaceSound surface, string soundId, out SoundBank soundBank) { }

	private void ValidateAndClean(bool remove) { }

}


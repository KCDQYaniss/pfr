//Type is in global namespace

[CreateAssetMenu(menuName = "MetaXRAudio/Acoustic Scene Group")]
internal class MetaXRAcousticSceneGroup : ScriptableObject
{
	[SerializeField]
	internal string[] sceneGuids; //Field offset: 0x18

	public MetaXRAcousticSceneGroup() { }

}


//Type is in global namespace

[CreateAssetMenu(menuName = "Seasons/WinterMaterialStub")]
public sealed class WinterMaterialStub : ScriptableObject, IWinterMaterial, ISeasonMaterial
{

	public WinterMaterialStub() { }

	public override void Fix() { }

}


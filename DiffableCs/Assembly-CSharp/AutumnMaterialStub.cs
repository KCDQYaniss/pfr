//Type is in global namespace

[CreateAssetMenu(menuName = "Seasons/AutumnMaterialStub")]
public sealed class AutumnMaterialStub : ScriptableObject, IAutumnMaterial, ISeasonMaterial
{

	public AutumnMaterialStub() { }

	public override void Fix() { }

}


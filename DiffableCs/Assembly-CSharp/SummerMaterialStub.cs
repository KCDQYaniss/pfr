//Type is in global namespace

[CreateAssetMenu(menuName = "Seasons/SummerMaterialStub")]
public sealed class SummerMaterialStub : ScriptableObject, ISummerMaterial, ISeasonMaterial
{

	public SummerMaterialStub() { }

	public override void Fix() { }

}


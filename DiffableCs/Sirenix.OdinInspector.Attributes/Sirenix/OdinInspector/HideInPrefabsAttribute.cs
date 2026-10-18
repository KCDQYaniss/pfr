namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767))]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
[EditorBrowsable(EditorBrowsableState::Never (1))]
[Obsolete("Use [HideIn(PrefabKind.PrefabAsset | PrefabKind.PrefabInstance)] instead.", False)]
public class HideInPrefabsAttribute : Attribute
{

	public HideInPrefabsAttribute() { }

}


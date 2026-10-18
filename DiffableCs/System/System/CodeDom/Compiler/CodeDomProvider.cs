namespace System.CodeDom.Compiler;

[ComVisible(True)]
[ToolboxItem(False)]
public abstract class CodeDomProvider : Component
{

	[ComVisible(False)]
	public static CodeDomProvider CreateProvider(string language) { }

	public override void GenerateCodeFromExpression(CodeExpression expression, TextWriter writer, CodeGeneratorOptions options) { }

}


namespace Snippets.T4;

public class TextTranformTests
{
    [Test]
    public void WriteSimpleHtml()
    {
        Template t = new()
        {
            MyText = "Hello World"
        };
        var text = t.TransformText();
        File.WriteAllText("out.html", text);
    }
}
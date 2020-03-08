using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

[BlockType(Name = "Home", Category = "Content",
    Icon = "fas fa-quote-right", Component = "quote-block")]
public class HomeBlock : Block
{
    /// <summary>
    /// Gets/sets the text body.
    /// </summary>
    [Field(Options = FieldOption.HalfWidth)]
    public StringField SubTitle { get; set; }

}
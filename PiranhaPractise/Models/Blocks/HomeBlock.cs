using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaPractise.Models.Blocks
{
    [BlockType(Name = "Home", Category = "Content",
        Icon = "fas fa-quote-right")]
    public class HomeBlock : Block
    {
        [Field(Options = FieldOption.HalfWidth)]
        public StringField Title { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField SubTitle { get; set; }

    }
}
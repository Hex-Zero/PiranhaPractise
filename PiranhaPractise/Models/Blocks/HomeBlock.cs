using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaPractise.Models.Blocks
{
    [BlockType(Name = "Home", Category = "Content",
        Icon = "fas fa-quote-right")]
    public class HomeBlock : Block
    {
        /// <summary>
        /// Gets/sets the text body.
        /// </summary>
        [Field(Options = FieldOption.HalfWidth)]
        public StringField Title { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField SubTitle { get; set; }

    }
}
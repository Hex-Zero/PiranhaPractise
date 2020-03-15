using PiranhaPractise.Models.Regions;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;
using Piranha.Extend.Fields;

namespace PiranhaPractise.Models
{
    [PageType(Title = "Blog archive", UseBlocks = false, IsArchive = true)]
    public class BlogArchive : Page<BlogArchive>
    {
        /// <summary>
        /// Gets/sets the archive hero.
        /// </summary>
        [Region(Display = RegionDisplayMode.Setting)]
        public Hero Hero { get; set; }

        /// <summary>
        /// Gets/sets the post archive.
        /// </summary>
        public PostArchive<DynamicPost> Archive { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField SubTitle { get; set; }
    }
}
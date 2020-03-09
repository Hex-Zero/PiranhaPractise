﻿using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;
using Piranha.Extend.Fields;
using PiranhaPractise.Models.Regions;

[SiteType(Title = "Permanents")]
public class Permanents : SiteContent<Permanents>
{
    [Region(Title = "Footer", Display = RegionDisplayMode.Setting)]
    public Footer Footer { get; set; }
}
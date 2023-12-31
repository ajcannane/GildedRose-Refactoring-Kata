using System.Collections.Generic;
using GildedRose;
using NUnit.Framework;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Test]
    public void Foo()
    {
        var items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
        var app = new GildedRose.GildedRose(items);
        app.UpdateQuality();
        Assert.AreEqual("fixme", items[0].Name);
    }
}
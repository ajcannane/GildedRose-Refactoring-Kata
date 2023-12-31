namespace GildedRose;

public abstract class BaseItem
{
    private readonly Item _item;
    private readonly int _depredationFactor;

    protected BaseItem(Item item, int depredationFactor)
    {
        _item = item;
        _depredationFactor = depredationFactor;
    }

    protected virtual int UpdateQuality()
    {
        return _item.Quality - _depredationFactor;
    }

    protected virtual int UpdateSellIn()
    {
        return _item.SellIn - 1;
    }

    public Item UpdateItem()
    {
        var newSellIn = UpdateSellIn();
        var newQuality = UpdateQuality() >= 0 ? UpdateQuality() : 0;
        return new Item
        {
            Name = _item.Name,
            Quality = newQuality,
            SellIn = newSellIn
        };
    }
}
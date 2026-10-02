using NUnit.Framework;

public class EditModeTest
{
    [Test]
    public void LaVidaNuncaEsNegativa()
    {
        int hp = 10;
        hp -= 50;
        if (hp < 0) hp = 0;

        Assert.AreEqual(1, hp);
    }
}
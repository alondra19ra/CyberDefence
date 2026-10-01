using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayModeTests
{
    [UnityTest]
    public IEnumerator ObjetoSeCreaCorrectamente()
    {
        GameObject obj = new GameObject("Jugador");
        yield return null;

        Assert.IsNotNull(obj);
        Assert.AreEqual("Jugador", obj.name);
    }
}
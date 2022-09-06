using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task2.Task2;

namespace Task2;

public class Tests
{
    [Test]
    public void Min3Test1()
    {
        That(Min3(2, 0, 3), Is.EqualTo(0));
    }

    [Test]
    public void Min3Test2()
    {
        That(Min3(-11, -9, -4), Is.EqualTo(-11));
    }

    [Test]
    public void Min3Test3()
    {
        That(Min3(0, 21, -21), Is.EqualTo(-21));
    }

    [Test]
    public void Max3Test1()
    {
        That(Max3(2, 0, 3), Is.EqualTo(3));
    }

    [Test]
    public void Max3Test2()
    {
        That(Max3(127, 0, -127), Is.EqualTo(127));
    }

    [Test]
    public void Max3Test3()
    {
        That(Max3(-17, 17, 17), Is.EqualTo(17));
    }

    [Test]
    public void Deg2RadTest1()
    {
        That(Deg2Rad(180.0), Is.EqualTo(Math.PI).Within(1e-5));
        That(Deg2Rad(2 * 360 + 180.0), Is.EqualTo(5 * Math.PI).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest1()
    {
        That(Rad2Deg(Math.PI), Is.EqualTo(180.0).Within(1e-5));
        That(Rad2Deg(5 * Math.PI), Is.EqualTo(5 * 180.0).Within(1e-5));
    }

    [Test]
    public void MoreRadDegTests()
    {
        That(Deg2Rad(-90.0), Is.EqualTo(-Math.PI / 2).Within(1e-5));
        That(Deg2Rad(0.0), Is.EqualTo(0.0).Within(1e-5));
        That(Deg2Rad(135.0), Is.EqualTo(3 * Math.PI / 4).Within(1e-5));
        That(Deg2Rad(180.0 - 2 * 360.0), Is.EqualTo(-3 * Math.PI).Within(1e-5));
        That(Deg2Rad(100 * 90.0), Is.EqualTo(50 * Math.PI).Within(1e-5));
        That(Rad2Deg(0.0), Is.EqualTo(0.0).Within(1e-5));
        That(Rad2Deg(-Math.PI), Is.EqualTo(-180.0).Within(1e-5));
        That(Rad2Deg(2 * Math.PI - 3.5 * Math.PI), Is.EqualTo(-270.0).Within(1e-5));
        That(Rad2Deg(Math.PI / 4), Is.EqualTo(45.0).Within(1e-5));
        That(Rad2Deg(-Math.PI / 8), Is.EqualTo(-22.5).Within(1e-5));
    }
}
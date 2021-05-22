using NUnit.Framework;
using SolvingProblems.BasicCSharp.NewOverrideExample;

namespace SolvingProblems.Tests.BasicCSharp.NewOverrideExample
{
    public class NewOverrideExampleTest
    {
        [Test]
        public void Test()
        {
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();

            Assert.That(bc.BaseMethod(), Is.EqualTo(MethodType.Base));
            Assert.That(dc.BaseMethod(), Is.EqualTo(MethodType.Base));
            Assert.That(dc.DerivedMethod(), Is.EqualTo(MethodType.Derived));
            Assert.That(bcdc.BaseMethod(), Is.EqualTo(MethodType.Base));
        }

        [Test]
        public void BothMethodsTest()
        {
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();

            Assert.That(bc.BothMethod(), Is.EqualTo(MethodType.Base));
            Assert.That(dc.BothMethod(), Is.EqualTo(MethodType.Derived));
            Assert.That(bcdc.BothMethod(), Is.EqualTo(MethodType.Base));
        }


        [Test]
        public void OverridedMethodsTest()
        {
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();

            Assert.That(bc.OverridedMethod(), Is.EqualTo(MethodType.Base));
            Assert.That(dc.OverridedMethod(), Is.EqualTo(MethodType.Overrided));

            Assert.That(bcdc.OverridedMethod(), Is.EqualTo(MethodType.Overrided));
        }
    }
}
﻿namespace TestNUnit
{
    using System;
    using System.Collections.Generic;
    using FluentAssertions;
    using NSubstitute;
    using NUnit.Framework;

    class BaseClass
    {

        public void AssertSomething()
        {
            Assert.IsTrue(true);
        }

        public void ShouldSomething()
        {
            Assert.IsTrue(true);
        }

        public void ExpectSomething()
        {
            Assert.IsTrue(true);
        }

        public void MustSomething()
        {
            Assert.IsTrue(true);
        }

        public void VerifySomething()
        {
            Assert.IsTrue(true);
        }

        public void ValidateSomething()
        {
            Assert.IsTrue(true);
        }
    }

    [TestFixture]
    class TestAttributeTests : BaseClass
    {
        [Test]
        public void Test1() // Noncompliant {{Add at least one assertion to this test case.}}
//                  ^^^^^
        {
            var x = 42;
        }

        [Test]
        public void Test2()
        {
            var x = 42;
            Assert.AreEqual(x, 42);
        }

        [Test]
        public void Test3()
        {
            var x = 42;
            NUnit.Framework.Assert.AreEqual(x, 42);
        }

        [Test]
        public void Test5()
        {
            var x = 42;
            x.Should().Be(42);
        }

        [Test]
        public void Test8()
        {
            AssertSomething();
        }

        [Test]
        public void Test9()
        {
            ShouldSomething();
        }

        [Test]
        public void Test10()
        {
            ExpectSomething();
        }

        [Test]
        public void Test11()
        {
            MustSomething();
        }

        [Test]
        public void Test12()
        {
            VerifySomething();
        }

        [Test]
        public void Test13()
        {
            ValidateSomething();
        }

        [Test]
        public void Test14()
        {
            dynamic d = 10;
            Assert.AreEqual(d, 10.0);
        }

        [Test]
        [Ignore("Some reason")]
        public void Test15() // Don't raise on skipped test methods
        {
        }
    }

    [TestFixture]
    class TestCaseAttributeTests : BaseClass
    {
        [TestCase]
        public void TestCase1() // Noncompliant {{Add at least one assertion to this test case.}}
//                  ^^^^^^^^^
        {
            var x = 42;
        }

        [TestCase]
        public void TestCase2()
        {
            var x = 42;
            Assert.AreEqual(x, 42);
        }

        [TestCase]
        public void TestCase3()
        {
            var x = 42;
            NUnit.Framework.Assert.AreEqual(x, 42);
        }

        [TestCase]
        public void TestCase5()
        {
            var x = 42;
            x.Should().Be(42);
        }

        [TestCase]
        public void TestCase8()
        {
            AssertSomething();
        }

        [TestCase]
        public void TestCase9()
        {
            ShouldSomething();
        }

        [TestCase]
        public void TestCase10()
        {
            ExpectSomething();
        }

        [TestCase]
        public void TestCase11()
        {
            MustSomething();
        }

        [TestCase]
        public void TestCase12()
        {
            VerifySomething();
        }

        [TestCase]
        public void TestCase13()
        {
            ValidateSomething();
        }

        [TestCase]
        public void TestCase14()
        {
            dynamic d = 10;
            Assert.AreEqual(d, 10.0);
        }

        [TestCase]
        [Ignore("Some reason")]
        public void TestCase15() // Don't raise on skipped test methods
        {
        }
    }

    [TestFixture]
    class TestCaseSourceAttributeTests : BaseClass
    {

        [TestCaseSource("Foo")]
        public void TestCaseSource1() // Noncompliant {{Add at least one assertion to this test case.}}
//                  ^^^^^^^^^^^^^^^
        {
            var x = 42;
        }

        [TestCaseSource("Foo")]
        public void TestCaseSource2()
        {
            var x = 42;
            Assert.AreEqual(x, 42);
        }

        [TestCaseSource("Foo")]
        public void TestCaseSource3()
        {
            var x = 42;
            NUnit.Framework.Assert.AreEqual(x, 42);
        }

        [TestCaseSource("Foo")]
        public void TestCaseSource5()
        {
            var x = 42;
            x.Should().Be(42);
        }

        [TestCaseSource("Foo")]
        public void TestCaseSource8()
        {
            AssertSomething();
        }

        [TestCaseSource("Foo")]
        public void TestCaseSource9()
        {
            ShouldSomething();
        }

        [TestCaseSource("Foo")]
        public void TestCaseSource10()
        {
            ExpectSomething();
        }

        [TestCaseSource("Foo")]
        public void TestCaseSource11()
        {
            MustSomething();
        }

        [TestCaseSource("Foo")]
        public void TestCaseSource12()
        {
            VerifySomething();
        }

        [TestCaseSource("Foo")]
        public void TestCaseSource13()
        {
            ValidateSomething();
        }

        [TestCaseSource("Foo")]
        public void TestCaseSource14()
        {
            dynamic d = 10;
            Assert.AreEqual(d, 10.0);
        }

        [TestCaseSource("Foo")]
        [Ignore("Some reason")]
        public void TestCaseSource15() // Don't raise on skipped test methods
        {
        }
    }

    [TestFixture]
    class TheoryAttributeTests : BaseClass
    {

        [Theory]
        public void Theory1() // Noncompliant {{Add at least one assertion to this test case.}}
//                  ^^^^^^^
        {
            var x = 42;
        }

        [Theory]
        public void Theory2()
        {
            var x = 42;
            Assert.AreEqual(x, 42);
        }

        [Theory]
        public void Theory3()
        {
            var x = 42;
            NUnit.Framework.Assert.AreEqual(x, 42);
        }

        [Theory]
        public void Theory5()
        {
            var x = 42;
            x.Should().Be(42);
        }

        [Theory]
        public void Theory8()
        {
            AssertSomething();
        }

        [Theory]
        public void Theory9()
        {
            ShouldSomething();
        }

        [Theory]
        public void Theory10()
        {
            ExpectSomething();
        }

        [Theory]
        public void Theory11()
        {
            MustSomething();
        }

        [Theory]
        public void Theory12()
        {
            VerifySomething();
        }

        [Theory]
        public void Theory13()
        {
            ValidateSomething();
        }

        [Theory]
        public void Theory14()
        {
            dynamic d = 10;
            Assert.AreEqual(d, 10.0);
        }

        [Theory]
        [Ignore("Some reason")]
        public void Theory15() // Don't raise on skipped test methods
        {
        }
    }

    [TestFixture]
    public class TypeExtensionsTests
    {
        [TestCase(typeof(string), ExpectedResult = "System.String")]
        [TestCase(typeof(string[]), ExpectedResult = "System.String[]")]
        [TestCase(typeof(List<string>), ExpectedResult = "List<System.String>")]
        [TestCase(typeof(List<(string, int)>), ExpectedResult = "List<ValueTuple<System.String,System.Int32>>")]
        public string GetFriendlyFullName(Type type)
        {
            return type.GetType().ToString();
        }

        [TestCase(typeof(string[]), "System.String[]")]
        public string NoNamedParameter(Type type) // Noncompliant FP
        {
            return type.GetType().ToString();
        }
    }

    [TestFixture]
    class NSubstituteTests
    {
        private readonly ICalculator calculator;

        public NSubstituteTests()
        {
            calculator = Substitute.For<ICalculator>();
        }

        [TestCase]
        public void NoAssert() // Noncompliant
        {
        }

        [TestCase]
        public void Received()
        {
            calculator.Received().Add(1, 2);
        }

        [TestCase]
        public void ReceivedExpression() => calculator.Received().Add(1, 2);

        [TestCase]
        public void ReceivedNameSpace() => NSubstitute.SubstituteExtensions.Received(calculator).Add(1, 2);

        [TestCase]
        public void ReceivedWithAnyArgs()
        {
            calculator.ReceivedWithAnyArgs().Add(0, 0);
        }

        [TestCase]
        public void DidNotReceived()
        {
            calculator.DidNotReceive().Add(1, 2);
        }

        [TestCase]
        public void DidNotReceiveWithAnyArgs()
        {
            calculator.DidNotReceiveWithAnyArgs().Add(1, 2);
        }

        [TestCase]
        public void ReceivedInOrder()
        {
            NSubstitute.Received.InOrder(() =>
            {
                calculator.Add(1, 2);
            });
        }
    }

    internal interface ICalculator
    {
        int Add(int a, int b);
    }
}


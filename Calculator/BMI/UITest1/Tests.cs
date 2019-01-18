using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace UITest1
{
    [TestFixture]
    public class Tests
    {
        AndroidApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            app = ConfigureApp
                    .Android
                    .ApkFile ("../../../BMICalculator/bin/Debug/BMICalculator.BMICalculator.apk")
                    .StartApp();
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
            app.EnterText(c => c.Marked("WeightText"), "70");
            app.EnterText(c => c.Marked("HeightText"), "1.8");
            app.Tap(c => c.Marked("Calculate"));
            app.WaitForElement(c => c.Marked("ResultText").Text("21.6"));
        }
    }
}


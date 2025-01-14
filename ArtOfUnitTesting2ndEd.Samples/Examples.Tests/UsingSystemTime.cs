﻿using System;
using NSubstitute;
using NUnit.Framework;

namespace Examples.Tests.Listing72
{

   
   [TestFixture]
   public class TestsWithTime
   {

        [Test]
        public void SettingSystemTime_Always_ChangesTime()
        {
            var dt = new DateTime(2000, 1, 1);
            var dt2=DateTime.Now;
            SystemTime.Set(dt2);

            string output = TimeLogger.CreateMessage("a");

            StringAssert.Contains("1/1/2000", output);
        }



        [TearDown]
        public void afterEachTest()
        {
            SystemTime.Reset();
        }


    }



}

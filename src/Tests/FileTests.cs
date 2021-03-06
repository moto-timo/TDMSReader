﻿using System;
using NUnit.Framework;
using Should;
using NationalInstruments.Tdms;

namespace Tests
{
    [TestFixture]
    public class FileTests
    {
        protected File File;

        [SetUp]
        public void Setup()
        {
            File = new File(Constants.SampleFile);
            File.Open();
        }

        [Test]
        public void Should_Contain_File_Information()
        {
            Console.WriteLine( new DateTime(2009, 4, 24, 8, 29, 45, DateTimeKind.Local));
            Console.WriteLine(new DateTime(2009, 4, 24, 8, 29, 45, DateTimeKind.Utc));
            File.Properties.Count.ShouldEqual(10);
            File.Properties["title"].ShouldEqual("DIAdem example data set");
            File.Properties["author"].ShouldEqual("National Instruments");
            File.Properties["registertxt3"].ShouldEqual(string.Empty);
            File.Properties["datetime"].ShouldEqual(new DateTime(2009, 4, 24, 8, 29, 45, DateTimeKind.Utc).ToLocalTime());
            File.Properties["registertxt1"].ShouldEqual(string.Empty);
            File.Properties["registertxt2"].ShouldEqual(string.Empty);
            File.Properties["name"].ShouldEqual("EXAMPLE");
            File.Properties["description"].ShouldEqual("Data set with numeric x/y-channels, waveform channels, and text channels in several channel groups");
            File.Properties["datestring"].ShouldEqual("24.04.2009");
            File.Properties["timestring"].ShouldEqual("10:29:45");
        }
    }
}
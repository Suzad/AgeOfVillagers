﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;

namespace AgeOfVillagers.Testing
{
    public class NationComponentFactoryTest
    {
        [Fact]
        public void ArabBedouinComponentFactoryTesting()
        {
            Point p = new Point(100, 100);
            ArabBedouinComponentFactory arabBedouinComponentFactory = new ArabBedouinComponentFactory();
            var expected = typeof(ArabBedouinHouse);
            Assert.IsType(expected, arabBedouinComponentFactory.getComponent("House", p));
        }

        [Fact]
        public void BdFarmerComponentFactoryTesting()
        {
            Point p = new Point(100, 100);
            BdFarmerComponentFactory bdFarmerComponentFactory = new BdFarmerComponentFactory();
            var expected = typeof(BdFarmerHouse);
            Assert.IsType(expected, bdFarmerComponentFactory.getComponent("House", p));
        }

        [Fact]
        public void EgyptianKingComponentFactoryTesting()
        {
            Point p = new Point(100, 100);
            EgyptianKingComponentFactory egyptianKingComponentFactory = new EgyptianKingComponentFactory();
            var expected = typeof(EgyptianKingHouse);
            Assert.IsType(expected, egyptianKingComponentFactory.getComponent("House", p));
        }

        [Fact]
        public void InuitHunterComponentFactoryTesting()
        {
            Point p = new Point(100, 100);
            InuitHunterComponentFactory inuitHunterComponentFactory = new InuitHunterComponentFactory();
            var expected = typeof(InuitHunterHouse);
            Assert.IsType(expected, inuitHunterComponentFactory.getComponent("House", p));
        }

        [Fact]
        public void NullComponentFactoryTesting()
        {
            Point p = new Point(100, 100);
            NullComponentFactory nullComponentFactory = new NullComponentFactory();
            var actual = nullComponentFactory.getComponent("House", p);
            var expected = typeof(NullVillageComponent);
            Assert.IsType(expected, actual);
        }

        [Fact]
        public void NationAbstractFactoryTesting()
        {
            var actual = NationComponentFactory.getNation("Bangladeshi Farmer");
            var expected = typeof(BdFarmerComponentFactory);
            Assert.IsType(expected, actual);
        }
    }
}

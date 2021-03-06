﻿using System.Linq;
using IdokladSdk.ApiFilters;
using NUnit.Framework;

namespace IdokladSdk.Integration.Tests
{
    [TestFixture]
    public class BankClientTests : IntegrationTestBase
    {
        [Test]
        public void IntegrationSteps()
        {
            Changes();
            int id = Banks();
            Bank(id);
        }

        private void Bank(int bankId)
        {
            // Act
            var result = ApiExplorer.BankClients.Bank(bankId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(bankId, result.Id);
        }

        private int Banks()
        {
            // Act
            var result = ApiExplorer.BankClients.Banks();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Data);
            Assert.That(result.Data.Count, Is.GreaterThan(0));

            return result.Data.FirstOrDefault().Id;
        }

        private void Changes()
        {
            // Act
            var result = ApiExplorer.BankClients.Changes(new ChangeFilter());

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

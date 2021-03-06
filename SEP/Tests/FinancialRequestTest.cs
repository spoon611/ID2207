﻿using BusinessTier;
using DataTier;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class FinancialRequestTest
    {
        private readonly FinancialRequestController financialRequestController = new FinancialRequestController();

        [TestMethod]
        public void GetFinancialRequestsTest()
        {
            // Arrange

            // Act
            List<FinancialRequest> financialRequests = financialRequestController.GetFinancialRequests();

            // Assert
            Assert.AreNotEqual(null, financialRequests);
        }

        [TestMethod]
        public void AddFinancialRequestTest()
        {
            // Arrange
            int oldCount = financialRequestController.GetFinancialRequests().Count;

            // Act
            financialRequestController.AddFinancialRequest(RequestingDepartment.Administration, new Event(), "122", "test", new User("test", "test", User.Roles.AdministrationDepartmentManager));
            List<FinancialRequest> financialRequests = financialRequestController.GetFinancialRequests();

            // Assert
            Assert.AreEqual(oldCount + 1, financialRequests.Count);
        }

        [TestMethod]
        public void SolveFinancialRequestTest()
        {
            // Arrange
            financialRequestController.AddFinancialRequest(RequestingDepartment.Administration, new Event(), "122", "test", new User("test", "test", User.Roles.AdministrationDepartmentManager));
            int oldCount = financialRequestController.GetFinancialRequests().Where(x => x.Result == true).ToList().Count;

            // Act
            financialRequestController.SolveFinancialRequest(financialRequestController.GetFinancialRequests()[0], "approve");
            List<FinancialRequest> financialRequests = financialRequestController.GetFinancialRequests().Where(x => x.Result == true).ToList();

            // Assert
            Assert.AreEqual(oldCount + 1, financialRequests.Count);
        }
    }
}

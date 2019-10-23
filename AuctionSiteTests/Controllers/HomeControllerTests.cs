using Microsoft.VisualStudio.TestTools.UnitTesting;
using AuctionSite.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionSite.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void Index_ReturnViewResult()
        {
            HomeController home = new HomeController();

            var result = home.Index();

            Assert.IsNotNull(result);
        }
    }
}
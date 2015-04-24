using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vjf.SyncTool.Business;
using NUnit.Framework;
namespace vjf.SyncTool.Business.Tests
{
    [TestFixture()]
    public class BaseCouponInfoListTests
    {
        [Test()]
        public void GetAllTest()
        {
            var curObj = BaseCouponInfoList.GetAll();
        }
    }
}

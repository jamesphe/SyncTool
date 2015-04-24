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
    public class BaseVouchActiveInfoTests
    {
        [Test()]
        public void GetByIdentificationTest()
        {
            var curObj = BaseVouchActiveInfo.GetByIdentification("VA142289060146146798");

        }
    }
}

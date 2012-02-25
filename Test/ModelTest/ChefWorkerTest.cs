using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Test.ModelTest
{
    [TestFixture]
    class ChefWorkerTest
    {
        [Test]
        public void AddWorkerToChefTest()
        {
            Model.Chef chef = new Model.Chef("Martin");
            Model.Worker worker1 = new Model.Worker();
            Model.Worker worker2 = new Model.Worker();

            chef.AddWorker(worker1);
            chef.AddWorker(worker2);

            Assert.True(chef.GetWorkers().Count == 2);
            Assert.True(worker1.Chef == chef);
        }
    }
}

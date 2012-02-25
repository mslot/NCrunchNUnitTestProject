using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Chef
    {
        public string Name { get; private set; }
        private ICollection<Worker> _workers = new List<Worker>();

        public Chef(string name)
        {
            Name = name;
        }

        public void AddWorker(Worker worker)
        {
            if (!_workers.Contains(worker))
            {

            }
        }


        public ICollection<Worker> GetWorkers()
        {
            throw new Exception();
            return _workers;
        }

        public void RemoveWorker(Worker worker)
        {
            _workers.Remove(worker);
        }
    }
}

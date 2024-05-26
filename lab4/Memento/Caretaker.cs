using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Memento
{
    public class Caretaker
    {
        private List<IMemento> _snapshots = new List<IMemento>();

        public void Backup(IMemento snapshot)
        {
            this._snapshots.Add(snapshot);
        }

        public void Undo()
        {
            if(this._snapshots.Count == 0)
            {
                Console.WriteLine("There are no snapshots");
                return;
            }
            var snapshot = this._snapshots.Last();
            snapshot.Restore();

            this._snapshots.Remove(snapshot);
        }

        public void RenderSnapshotList()
        {
            Console.WriteLine("Currently availbale snapshots:");
            this._snapshots.ForEach((snapshot) =>
            {
                Console.WriteLine($"{snapshot.Id}: {snapshot.Date}");

            });
        }
    }
}

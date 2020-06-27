using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.NameLookup
{
    public class Dictionary<TKey, TValue> where TKey : IComparable<TKey>
    {
        private LinkedList<KeyValuePair<TKey, TValue>> T = new LinkedList<KeyValuePair<TKey, TValue>>();
        //header cell? 
        private void NullCheck(TKey a)
        { 
            if (a == null)
            {
                //try catch? to throw an exception?
                MessageBox.Show("Argument Null Exception");
            }
        }

        private LinkedListCell<T> prevCell (TKey a)
        {
            a.CompareTo(T);
            int x = Convert.ToInt32(a);
            x--;
            ;
            return T;
        }

        public bool TryGetValue(TKey k, out TValue v)
        { 
        ///nxoiuabc
        }
    }
}

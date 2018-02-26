using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pk_Uppgift
{
    class ListViewItemComparer : IComparer
    {
        private int column;
        private SortOrder sorting;

        public ListViewItemComparer()
        {


        }

        public ListViewItemComparer(int column, SortOrder sorting)
        {
            this.column = column;
            this.sorting = sorting;
        }

        public int Compare(object x, object y)
        {
            int returnval;
            returnval = String.Compare(((ListViewItem)x).SubItems[column].Text, ((ListViewItem)y).SubItems[column].Text);
            if (sorting == SortOrder.Descending)
                returnval *= -1;
            return returnval;



        }

    }
}

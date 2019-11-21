using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardsMapper.Helpers
{
    static class ObjectListViewHelper
    {
        public enum ObjectListViewCollector { Empty, Selected, All }
        internal static List<T> CollectCheckedObjects<T>(this FastObjectListView listView, ObjectListViewCollector returnIfNoneChecked = ObjectListViewCollector.All)
        {
            if (listView.Objects == null || listView.GetItemCount() == 0) return new List<T>();

            List<T> list = new List<T>();
            if (listView.CheckedObjects.Count > 0)
            {
                foreach (var ch in listView.CheckedObjects)
                    list.Add((T)ch);
            }
            else
            {
                switch (returnIfNoneChecked)
                {
                    case ObjectListViewCollector.Empty: return list;
                    case ObjectListViewCollector.Selected:
                        if (listView.SelectedObject != null)
                            list.Add((T)listView.SelectedObject);
                        break;
                    case ObjectListViewCollector.All:
                        foreach (var item in listView.Objects)
                            list.Add((T)item);
                        break;
                }
            }
            return list;
        }
    }
}

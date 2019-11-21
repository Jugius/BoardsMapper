using Ookii.Dialogs;
using System.ComponentModel;

namespace BoardsMapper.DataManager
{
    interface IProcessor
    {
        void StartProcess(ProgressDialog dialog, DoWorkEventArgs e);
    }
}

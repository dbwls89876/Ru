using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCafeSNS
{
    enum State
    {
        board,
        club,
        notice
    }
    class FormManager
    {
        //Dictionary<State, Form> FormList;

        //private static FormManager _instance = new FormManager();

        //private FormManager()
        //{
        //    FormList = new Dictionary<State, Form>();
            
        //}

        //public void Show(State state)
        //{
        //    if(FormList.ContainsKey(state))
        //    {
        //        FormList[state].Show();
        //    }
        //}

        //public void Close()
        //{

        //}

        //public void AddControl(State state,Control control)
        //{
        //    FormList[state].Add(control);
        //}

        //public static FormManager getInstance()
        //{
        //    return _instance;
        //}

        //public void change (State state)
        //{
        //    foreach(Control c in FormList[state])
        //    {
        //        c.Visible = true;
        //    }
        //    foreach (Control c in FormList[currentState])
        //    {
        //        c.Visible = false;
        //    }
        //    currentState = state;
        //}
        //~FormManager()
        //{
        //    foreach(var f in FormList)
        //    {
        //        f.Value.Close();
        //    }
        //}
    }
}

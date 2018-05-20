﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
   public class ActionMenu : MenuItem
    {
        public ActionMenu(int i_Index, string i_MenuItemName) : base(i_Index, i_MenuItemName)
        {
            this.MenuItemName = i_MenuItemName;
            this.ItemIndex = i_Index;
        }
        internal override void doWhenChosen(int i_ParentIndex, string i_ParentName)
        {
            ReportAll ();
        }
        public void ReportAll()
        {
            foreach(IObservers observer in m_ReportObservers)
            {
                observer.Operation();
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace twozerofoureight
{
    public class Model
    {
        protected ArrayList oList;
		protected int sc = 0;
		public int over = 0;

		public Model()
        {
            oList = new ArrayList();
        }
		public int Getscore()
		{
			return sc;
		}

		public string isOver(int end)
		{
			if(end == 1)
			{
				return "GAME OVER";
			}
			else 
			{
				return "";
			}
		}
		public void NotifyAll()
        {
            foreach (View m in oList)
            {
                m.Notify(this);
            }
        }

        public void AttachObserver(View m)
        {
            oList.Add(m);
        }

    }
}

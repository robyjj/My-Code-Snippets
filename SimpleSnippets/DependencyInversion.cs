using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnippets
{
    public class DependencyInversion
    {
        public static void Run()
        {
           // UI ui = new UI();
        }


        public class UI
        {
            IBLL _bll;
            public UI(IBLL bll)
            {
                _bll = bll;
            }
            public string GetDetails()
            {
                return _bll.GetDetails();
            }
        }

        public class BLL:IBLL
        {
            IDAL _dal;
            public BLL(IDAL dal)
            {
                _dal = dal;
            }

            public string GetDetails()
            {
                return _dal.GetDetails();
            }
        }

        public class DAL : IDAL
        {    
            public string GetDetails()
            {
                return "Details";
            }
        }

        public interface IBLL
        {
            string GetDetails();
        }
        public interface IDAL
        {
            string GetDetails();
        }
    }
}

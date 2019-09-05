using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace efDebug
{
    class Outil
    {
        public static BourseContexte BrsCtx = new BourseContexte();
        public Outil()
        {
            try
            {
                BrsCtx.Database.Initialize(force: true);
            }
            catch (Exception e)
            {
                if (e.Message != "La clé est trop longue. Longueur maximale: 1000")
                    MessageBox.Show("La clé est trop longue???");
                else
                    MessageBox.Show(e.Message);
            }
        }
    }
}

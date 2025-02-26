using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie2.TP2
{
    internal abstract class Document
    {
        int numero;
        string titre;
        public Document( string title)
        {
           
            titre=title;
        }
        public int num
        {
            get{ return numero; }
            set{ numero=value; }
        }
         public string Title
        {
            get { return titre; }
            set { titre = value;}
        }
        
        public abstract string Description();
    }
}

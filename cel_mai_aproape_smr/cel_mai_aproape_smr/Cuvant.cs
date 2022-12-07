using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cel_mai_aproape_smr
{
    
    public class Cuvant
    {
        form_game fgame;
        String text;
        String cuv;
        int len_cuv;
        Random rd = new Random();

        public Cuvant(form_game fgame) { 
            this.fgame = fgame; 
        }

        public void create_cuv()
        {
            text = fgame.get_text_topic();  
            string[] lines = System.IO.File.ReadAllLines("../../topic_cuvs/"+ text +".txt");
            this.cuv = lines[rd.Next(100)]; 
            fgame.set_cuv(this.cuv);
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    public abstract class Game
    {
        public abstract void initialize();
        public abstract void startPlay();
        public abstract void endPlay();

        //template method
        public void play()
        {
            //initialize the game
            initialize();

            //start game
            startPlay();

            //end game
            endPlay();
        }
    }
}

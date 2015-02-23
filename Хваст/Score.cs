using System;
using System.Collections.Generic;
using System.Text;

namespace Хваст
{
    class Score
    {
        public int value;
        public string user;

        public Score(int value, string user)
        {
            this.user = user;
            this.value = value;
        }
    }
}

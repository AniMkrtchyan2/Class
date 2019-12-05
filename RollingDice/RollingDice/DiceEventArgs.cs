using System;
namespace RollingDice
{
       class DiceEventArgs : EventArgs
        {
           
            private readonly string message;

            public DiceEventArgs(string message)
            {
                this.message = message;
            }

            public string Message
            {
                get
                {
                    return this.message;
                }
            }
}
    }
